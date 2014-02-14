using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeHash
{
	public partial class ResultSelectionWindow : Form
	{
		private ResultSelectionWindow()
		{
			InitializeComponent();
		}

		public ResultSelectionWindow(Form1 form1)
			: this()
		{
			this.form1 = form1;
			this.listBox1.DisplayMember = "Title";
			foreach (var window in form1.HashResultWindows)
			{
				this.listBox1.Items.Add(window);
			}
		}

		public bool IsSomethingSelected
		{
			get
			{
				return this.listBox1.SelectedIndex >= 0;
			}
		}

		public HashResultWindow SelectedWindow
		{
			get
			{
				return (HashResultWindow)this.listBox1.SelectedItem;
			}
		}

		private Form1 form1;

		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void listBox1_DoubleClick(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}
	}
}
