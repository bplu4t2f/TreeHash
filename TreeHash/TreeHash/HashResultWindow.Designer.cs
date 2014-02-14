namespace TreeHash
{
	partial class HashResultWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compareToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compareToOtherResultWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.showResultToolStripMenuItem,
            this.compareToFileToolStripMenuItem,
            this.compareToOtherResultWindowToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(853, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.saveToolStripMenuItem.Text = "Save to file...";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// showResultToolStripMenuItem
			// 
			this.showResultToolStripMenuItem.Name = "showResultToolStripMenuItem";
			this.showResultToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.showResultToolStripMenuItem.Text = "Show result";
			this.showResultToolStripMenuItem.Click += new System.EventHandler(this.showResultToolStripMenuItem_Click);
			// 
			// compareToFileToolStripMenuItem
			// 
			this.compareToFileToolStripMenuItem.Name = "compareToFileToolStripMenuItem";
			this.compareToFileToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
			this.compareToFileToolStripMenuItem.Text = "Compare to file...";
			this.compareToFileToolStripMenuItem.Click += new System.EventHandler(this.compareToFileToolStripMenuItem_Click);
			// 
			// compareToOtherResultWindowToolStripMenuItem
			// 
			this.compareToOtherResultWindowToolStripMenuItem.Name = "compareToOtherResultWindowToolStripMenuItem";
			this.compareToOtherResultWindowToolStripMenuItem.Size = new System.Drawing.Size(199, 20);
			this.compareToOtherResultWindowToolStripMenuItem.Text = "Compare to other result window...";
			this.compareToOtherResultWindowToolStripMenuItem.Click += new System.EventHandler(this.compareToOtherResultWindowToolStripMenuItem_Click);
			// 
			// richTextBoxContent
			// 
			this.richTextBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBoxContent.Location = new System.Drawing.Point(0, 24);
			this.richTextBoxContent.Name = "richTextBoxContent";
			this.richTextBoxContent.ReadOnly = true;
			this.richTextBoxContent.Size = new System.Drawing.Size(853, 373);
			this.richTextBoxContent.TabIndex = 2;
			this.richTextBoxContent.Text = "";
			this.richTextBoxContent.WordWrap = false;
			// 
			// HashResultWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(853, 397);
			this.Controls.Add(this.richTextBoxContent);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "HashResultWindow";
			this.Text = "Hash Results";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showResultToolStripMenuItem;
		private System.Windows.Forms.RichTextBox richTextBoxContent;
		private System.Windows.Forms.ToolStripMenuItem compareToFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compareToOtherResultWindowToolStripMenuItem;
	}
}