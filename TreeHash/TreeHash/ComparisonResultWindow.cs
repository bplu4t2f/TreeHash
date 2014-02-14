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
	public partial class ComparisonResultWindow : Form
	{
		public ComparisonResultWindow()
		{
			InitializeComponent();
		}

		private Form1 form1;

		protected override void OnClosing(CancelEventArgs e)
		{
			if (!saved)
			{
				var result = MessageBox.Show("The results have not been saved yet. Do you really want to close the result window?", "Unsaved results", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				if (result != System.Windows.Forms.DialogResult.OK)
				{
					e.Cancel = true;
				}
			}
			base.OnClosing(e);
		}

		string _content;
		public string Content
		{
			get { return _content; }
			set
			{
				if (String.IsNullOrEmpty(value))
				{
					_content = "Files match";
				}
				else
				{
					_content = value;
				}
				if (value.Length < 50000)
				{
					this.richTextBoxContent.Text = _content;
				}
				else
				{
					this.richTextBoxContent.Text = "The result is very long. Click the button above to show it.";
				}
			}
		}

		bool saved;

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				using (var dialog = new SaveFileDialog())
				{
					if (Directory.Exists(Properties.Settings.Default.SaveToFileDir))
					{
						dialog.InitialDirectory = Properties.Settings.Default.SaveToFileDir;
					}
					dialog.Filter = "Text files|*.txt";
					var result = dialog.ShowDialog();
					if (result != System.Windows.Forms.DialogResult.OK)
					{
						return;
					}
					var filename = dialog.FileName;
					Properties.Settings.Default.SaveToFileDir = Path.GetDirectoryName(filename);
					File.WriteAllText(filename, this.Content);
					saved = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An exception occurred while saving: " + ex.Message);
			}
		}

		private void showResultToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.richTextBoxContent.Text = this.Content;
			}
			catch (Exception ex)
			{
				MessageBox.Show("An exception occurred while displaying the results: " + ex.Message);
			}
		}
	}
}
