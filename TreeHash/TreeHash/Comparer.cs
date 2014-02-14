using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeHash
{
	public static class Comparer
	{
		public static string Compare(string[] content1, string[] content2)
		{
			StringBuilder errors = new StringBuilder();

			Dictionary<string, string> dict1 = new Dictionary<string, string>();

			foreach (var line in content1)
			{
				var trimmedLine = line.Trim();
				if (String.IsNullOrEmpty(trimmedLine))
				{
					continue;
				}
				var parts = trimmedLine.ToLower().Split('\t');
				if (parts.Length != 2)
				{
					errors.Append("The input file has an unrecognized format.");
					return errors.ToString();
				}
				dict1.Add(parts[1], parts[0]);
			}

			foreach (var line in content2)
			{
				var trimmedLine = line.Trim();
				if (String.IsNullOrEmpty(trimmedLine))
				{
					continue;
				}
				var parts = trimmedLine.ToLower().Split('\t');
				if (parts.Length != 2)
				{
					errors.Append("The input file has an unrecognized format.");
					return errors.ToString();
				}
				string hash1;
				var success = dict1.TryGetValue(parts[1], out hash1);
				if (success)
				{
					if (hash1 != parts[0])
					{
						errors.AppendLine("Entries for '" + parts[1] + "' mismatch (file 1: " + hash1 + " / file 2: " + parts[0] + ")");
					}
					dict1.Remove(parts[1]);
				}
				else
				{
					errors.AppendLine("Entry for '" + parts[1] + "' not found in file 1.");
				}
			}

			foreach (var entry in dict1)
			{
				errors.AppendLine("Entry for '" + entry.Key + "' not found in file 2.");
			}

			return errors.ToString();
		}

		public static Task<string> CompareAsync(string[] content1, string[] content2)
		{
			var task = new Task<string>(() => Compare(content1, content2));
			return task;
		}
	}
}
