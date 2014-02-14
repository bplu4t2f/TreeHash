using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TreeHash
{
	public partial class CompareWindow : Form
	{
		public CompareWindow()
		{
			InitializeComponent();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			this.Cancel();
			base.OnClosing(e);
		}

		string[] content1;
		string[] content2;

		string errors;

		string file1;
		string file2;

		BackgroundWorker backgroundWorker;

		private void buttonCompare_Click(object sender, EventArgs e)
		{
			try
			{
				if (String.IsNullOrEmpty(this.textBoxFile1.Text) || String.IsNullOrEmpty(this.textBoxFile2.Text))
				{
					return;
				}
				this.file1 = this.textBoxFile1.Text;
				this.file2 = this.textBoxFile2.Text;

				abort = false;

				this.buttonCancel.Enabled = true;
				this.buttonCompare.Enabled = false;

				this.backgroundWorker = new BackgroundWorker();
				this.backgroundWorker.DoWork += this.Work;
				this.backgroundWorker.RunWorkerCompleted += this.WorkCompleted;
				this.backgroundWorker.RunWorkerAsync();
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error occurred while starting the operation: " + ex.Message);
			}
		}

		private void WorkCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show("An error occurred while comparing: " + e.Error.Message);
			}
			else
			{
				var outputWindow = new ComparisonResultWindow();
				var errstr = this.errors.ToString();
				if (String.IsNullOrEmpty(errstr))
				{
					errstr = "Files match.";
				}
				outputWindow.Content = errstr;
				outputWindow.Show();
			}
			this.buttonCancel.Enabled = false;
			this.buttonCompare.Enabled = true;
		}

		private void Cancel()
		{
			this.abort = true;
		}

		bool abort;

		private void Work(object sender, DoWorkEventArgs e)
		{
			content1 = File.ReadAllLines(this.textBoxFile1.Text);

			if (abort)
			{
				return;
			}

			content2 = File.ReadAllLines(this.textBoxFile2.Text);

			if (abort)
			{
				return;
			}

			this.errors = Comparer.Compare(content1, content2);
		}

		private static string FileBrowser(string initialDirectory)
		{
			using (var dialog = new OpenFileDialog())
			{
				if (Directory.Exists(initialDirectory))
				{
					dialog.InitialDirectory = initialDirectory;
				}
				dialog.Filter = "Text files|*.txt";
				var result = dialog.ShowDialog();
				if (result != System.Windows.Forms.DialogResult.OK)
				{
					return null;
				}
				return dialog.FileName;
			}
		}

		private void buttonBrowse1_Click(object sender, EventArgs e)
		{
			try
			{
				string initialDirectory = "";
				if (File.Exists(this.textBoxFile1.Text))
				{
					initialDirectory = Path.GetDirectoryName(this.textBoxFile1.Text);
				}
				var dir = FileBrowser(initialDirectory);
				if (dir != null)
				{
					this.textBoxFile1.Text = dir;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An exception occurred while browsing: " + ex.Message);
			}
		}

		private void buttonBrowse2_Click(object sender, EventArgs e)
		{
			try
			{
				string initialDirectory = "";
				if (File.Exists(this.textBoxFile2.Text))
				{
					initialDirectory = Path.GetDirectoryName(this.textBoxFile2.Text);
				}
				var dir = FileBrowser(initialDirectory);
				if (dir != null)
				{
					this.textBoxFile2.Text = dir;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An exception occurred while browsing: " + ex.Message);
			}
		}

		private void buttonClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.Cancel();
		}
	}
}
