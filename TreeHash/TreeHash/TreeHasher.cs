using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace TreeHash
{
	public class TreeHasher
	{
		public TreeHasher(HashMode mode, IHashAlgorithmFactory factory, bool ignoreHiddenUnixFiles, bool ignoreFileErrors)
		{
			switch (mode)
			{
				case HashMode.Full: fullMode = true; break;
				case HashMode.Compact: compactMode = true; break;
				case HashMode.Single: singleMode = true; break;
			}
			this.factory = factory;
			this.ignoreHiddenUnixFiles = ignoreHiddenUnixFiles;
			this.ignoreFileErrors = ignoreFileErrors;
		}

		public void Abort()
		{
			this.abort = true;
		}

		bool abort;
		bool ignoreHiddenUnixFiles;
		bool ignoreFileErrors;
		IHashAlgorithmFactory factory;
		bool singleMode;
		bool compactMode;
		bool fullMode;

		StringBuilder output;

		public string Output
		{
			get
			{
				if (this.output == null)
				{
					return null;
				}
				return this.output.ToString();
			}
		}

		HashAlgorithm algorithm;

		string root;
		int rootLength;

		long bytesProcessed;
		public long BytesProcessed
		{
			get { return this.bytesProcessed; }
		}

		byte[] zeroArray = new byte[0];

		public void Hash(string directory)
		{
			this.abort = false;
			this.root = directory.TrimEnd('\\');
			this.rootLength = root.Length;
			this.output = new StringBuilder();
			if (this.singleMode)
			{
				this.algorithm = this.factory.GetHashAlgorithm();
			}
			RecursiveHash(this.root);
			if (this.singleMode)
			{
				this.algorithm.TransformFinalBlock(zeroArray, 0, 0);
				Append(algorithm.Hash);
			}
		}

		const int BUFFER_SIZE = 50000000;
		byte[] buffer = new byte[BUFFER_SIZE];

		private void RecursiveHash(string directory)
		{
			if (this.compactMode)
			{
				this.algorithm = this.factory.GetHashAlgorithm();
			}

			try
			{
				var files = Directory.EnumerateFiles(directory);
				foreach (var file in files)
				{
					try
					{
						if (this.abort)
						{
							return;
						}
						if (this.ignoreHiddenUnixFiles && Path.GetFileName(file).StartsWith("."))
						{
							continue;
						}
						using (var handle = File.OpenRead(file))
						{
							if (this.fullMode)
							{
								this.algorithm = this.factory.GetHashAlgorithm();
							}
							var numBytes = handle.Read(buffer, 0, BUFFER_SIZE);
							while (numBytes > 0)
							{
								if (this.abort)
								{
									return;
								}
								bytesProcessed += numBytes;
								this.algorithm.TransformBlock(buffer, 0, numBytes, buffer, 0);
								numBytes = handle.Read(buffer, 0, BUFFER_SIZE);
							}
						}
						if (this.fullMode)
						{
							this.algorithm.TransformFinalBlock(zeroArray, 0, 0);
							Append(this.algorithm.Hash, Path.Combine(directory, Path.GetFileName(file)));
						}
						else
						{
							var filename = Encoding.UTF8.GetBytes(Path.GetFileName(file));
							this.algorithm.TransformBlock(filename, 0, filename.Length, filename, 0);
						}
					}
					catch
					{
						if (!this.ignoreFileErrors)
						{
							throw;
						}
					}
				}
				if (this.singleMode)
				{
					if (directory != this.root)
					{
						var dirnameBytes = Encoding.UTF8.GetBytes(Path.GetFileName(directory));
						this.algorithm.TransformBlock(dirnameBytes, 0, dirnameBytes.Length, dirnameBytes, 0);
					}
				}
				else if (this.compactMode)
				{
					this.algorithm.TransformFinalBlock(zeroArray, 0, 0);
					Append(algorithm.Hash, directory);
				}
			}
			catch
			{
				if (!this.ignoreFileErrors)
				{
					throw;
				}
			}

			try
			{
				var subdirs = Directory.EnumerateDirectories(directory);
				foreach (var subdir in subdirs)
				{
					if (this.abort)
					{
						return;
					}
					RecursiveHash(Path.Combine(directory, Path.GetFileName(subdir)));
				}
			}
			catch
			{
				if (!this.ignoreFileErrors)
				{
					throw;
				}
			}
		}

		private void Append(byte[] bytes)
		{
			foreach (var b in bytes)
			{
				this.output.Append(b.ToString("x2"));
			}
			this.output.AppendLine();
		}

		private void Append(byte[] bytes, string file)
		{
			foreach (var b in bytes)
			{
				this.output.Append(b.ToString("x2"));
			}
			this.output.Append("\t");
			this.output.AppendLine(file.Substring(rootLength));
		}
	}

	public enum HashMode
	{
		Full,
		Compact,
		Single
	}
}
