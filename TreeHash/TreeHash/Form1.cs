using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace TreeHash
{
	public partial class Form1 : Form, IHashAlgorithmFactory
	{
		public Form1()
		{
			InitializeComponent();

			Properties.Settings.Default.Upgrade();
			this.textBoxSelectedDirectory.Text = Properties.Settings.Default.SelectedDirectory;

			this.progressUpdateTimer = new Timer();
			this.progressUpdateTimer.Tick += this.TimerTick;
			this.progressUpdateTimer.Interval = 1000;
			this.progressUpdateTimer.Start();
		}

		Timer progressUpdateTimer;

		object hasherSync = new object();

		protected override void OnClosing(CancelEventArgs e)
		{
			this.progressUpdateTimer.Stop();
			this.CancelHash();

			Properties.Settings.Default.SelectedDirectory = this.textBoxSelectedDirectory.Text;
			Properties.Settings.Default.Save();

			base.OnClosing(e);
		}

		private string SelectedDirectory
		{
			get
			{
				return this.textBoxSelectedDirectory.Text;
			}
			set
			{
				this.textBoxSelectedDirectory.Text = value;
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			try
			{
				using (var dialog = new FolderBrowserDialog())
				{
					if (Directory.Exists(this.SelectedDirectory))
					{
						dialog.SelectedPath = this.SelectedDirectory;
					}
					dialog.Description = "This dialog is such a pain in the ass. Sorry.";
					dialog.ShowNewFolderButton = false;
					var result = dialog.ShowDialog();
					if (result != System.Windows.Forms.DialogResult.OK)
					{
						return;
					}
					this.SelectedDirectory = dialog.SelectedPath;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An exception occurred while browsing: " + ex.Message);
			}
		}

		private void buttonHash_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(this.SelectedDirectory))
			{
				MessageBox.Show("The specified directory does not exist.");
				return;
			}
			try
			{
				StartHash();
			}
			catch (Exception ex)
			{
				MessageBox.Show("An exception has occurred while starting the operation: " + ex.Message);
			}
		}

		BackgroundWorker backgroundWorker;

		private string currentDirectory;
		private HashMode currentMode;

		private bool useSHA256;

		public HashAlgorithm GetHashAlgorithm()
		{
			if (this.useSHA256)
			{
				return SHA256.Create();
			}
			else
			{
				return MD5.Create();
			}
		}
		
		private void StartHash()
		{
			lock (this.hasherSync)
			{
				if (this.hasher != null)
				{
					throw new InvalidOperationException("Hashing is already in progress.");
				}

				this.buttonCancel.Enabled = true;
				this.buttonHash.Enabled = false;

				this.useSHA256 = this.radioButtonSHA256.Checked;

				this.currentDirectory = this.SelectedDirectory;

				if (this.radioButtonSingle.Checked)
				{
					currentMode = HashMode.Single;
				}
				else if (this.radioButtonCompact.Checked)
				{
					currentMode = HashMode.Compact;
				}
				else
				{
					currentMode = HashMode.Full;
				}

				this.hasher = new TreeHasher(this.currentMode, this, this.checkBoxIgnoreHiddenFiles.Checked, this.checkBoxIgnoreFileErrors.Checked);

				this.backgroundWorker = new BackgroundWorker();
				this.backgroundWorker.DoWork += this.HashWork;
				this.backgroundWorker.RunWorkerCompleted += this.WorkerCompleted;
				this.backgroundWorker.RunWorkerAsync();
			}
		}

		TreeHasher hasher;

		private void HashWork(object sender, DoWorkEventArgs e)
		{
			this.hasher.Hash(currentDirectory);
		}

		private void TimerTick(object sender, EventArgs e)
		{
			lock (this.hasherSync)
			{
				if (this.hasher != null)
				{
					UpdateLabel();
				}
			}
		}

		private void UpdateLabel()
		{
			var bytesProcessed = this.hasher.BytesProcessed;
			if (bytesProcessed > 10737418240)
			{
				// >10 GB
				this.label1.Text = "Processed: " + (bytesProcessed / 1073741824.0).ToString("f2") + " GB";
			}
			else
			{
				this.label1.Text = "Processed: " + (bytesProcessed / 1048576.0).ToString("f2") + " MB";
			}
		}

		List<HashResultWindow> _hashResultWindows = new List<HashResultWindow>();
		/// <summary>
		/// Gets a list of all currently shown output windows.
		/// </summary>
		public List<HashResultWindow> HashResultWindows
		{
			get
			{
				return _hashResultWindows;
			}
		}

		private void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show("An error occurred during the hash operation: " + e.Error.Message);
			}
			else
			{
				var outputWindow = new HashResultWindow(this, this.currentDirectory);
				outputWindow.Content = this.hasher.Output;
				outputWindow.FormClosed += this.HandleOutputWindowClosed;
				this.HashResultWindows.Add(outputWindow);
				outputWindow.Show();
			}

			EndHash();
		}

		private void HandleOutputWindowClosed(object sender, EventArgs e)
		{
			this.HashResultWindows.Remove((HashResultWindow)sender);
		}

		private void EndHash()
		{
			lock (this.hasherSync)
			{
				this.backgroundWorker = null;
				UpdateLabel();
				this.hasher = null;

				this.buttonCancel.Enabled = false;
				this.buttonHash.Enabled = true;
			}
		}

		private void CancelHash()
		{
			lock (this.hasherSync)
			{
				if (this.hasher != null)
				{
					this.hasher.Abort();
				}
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.CancelHash();
		}

		CompareWindow compareWindow;

		private void buttonCompare_Click(object sender, EventArgs e)
		{
			if (this.compareWindow != null)
			{
				this.compareWindow.Activate();
				return;
			}
			this.compareWindow = new CompareWindow();
			this.compareWindow.FormClosed += this.CompareWindowClosed;
			this.compareWindow.Show();
		}

		private void CompareWindowClosed(object sender, EventArgs e)
		{
			this.compareWindow = null;
		}
	}
}
