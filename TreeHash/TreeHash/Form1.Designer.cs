namespace TreeHash
{
	partial class Form1
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
			this.radioButtonMD5 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButtonSHA256 = new System.Windows.Forms.RadioButton();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonHash = new System.Windows.Forms.Button();
			this.textBoxSelectedDirectory = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButtonSingle = new System.Windows.Forms.RadioButton();
			this.radioButtonFull = new System.Windows.Forms.RadioButton();
			this.radioButtonCompact = new System.Windows.Forms.RadioButton();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBoxIgnoreHiddenFiles = new System.Windows.Forms.CheckBox();
			this.buttonCompare = new System.Windows.Forms.Button();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.checkBoxIgnoreFileErrors = new System.Windows.Forms.CheckBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioButtonMD5
			// 
			this.radioButtonMD5.AutoSize = true;
			this.radioButtonMD5.Checked = true;
			this.radioButtonMD5.Location = new System.Drawing.Point(12, 19);
			this.radioButtonMD5.Name = "radioButtonMD5";
			this.radioButtonMD5.Size = new System.Drawing.Size(124, 17);
			this.radioButtonMD5.TabIndex = 1;
			this.radioButtonMD5.TabStop = true;
			this.radioButtonMD5.Text = "MD5 (recommended)";
			this.radioButtonMD5.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButtonSHA256);
			this.groupBox1.Controls.Add(this.radioButtonMD5);
			this.groupBox1.Location = new System.Drawing.Point(274, 67);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(9, 3, 3, 3);
			this.groupBox1.Size = new System.Drawing.Size(171, 95);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Algorithm";
			// 
			// radioButtonSHA256
			// 
			this.radioButtonSHA256.AutoSize = true;
			this.radioButtonSHA256.Location = new System.Drawing.Point(12, 42);
			this.radioButtonSHA256.Name = "radioButtonSHA256";
			this.radioButtonSHA256.Size = new System.Drawing.Size(65, 17);
			this.radioButtonSHA256.TabIndex = 2;
			this.radioButtonSHA256.Text = "SHA256";
			this.radioButtonSHA256.UseVisualStyleBackColor = true;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(370, 199);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 3;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonHash
			// 
			this.buttonHash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonHash.Location = new System.Drawing.Point(289, 199);
			this.buttonHash.Name = "buttonHash";
			this.buttonHash.Size = new System.Drawing.Size(75, 23);
			this.buttonHash.TabIndex = 4;
			this.buttonHash.Text = "Hash";
			this.buttonHash.UseVisualStyleBackColor = true;
			this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
			// 
			// textBoxSelectedDirectory
			// 
			this.textBoxSelectedDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSelectedDirectory.Location = new System.Drawing.Point(12, 41);
			this.textBoxSelectedDirectory.Name = "textBoxSelectedDirectory";
			this.textBoxSelectedDirectory.Size = new System.Drawing.Size(404, 20);
			this.textBoxSelectedDirectory.TabIndex = 5;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButtonSingle);
			this.groupBox2.Controls.Add(this.radioButtonFull);
			this.groupBox2.Controls.Add(this.radioButtonCompact);
			this.groupBox2.Location = new System.Drawing.Point(12, 67);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(9, 3, 3, 3);
			this.groupBox2.Size = new System.Drawing.Size(256, 95);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Mode";
			// 
			// radioButtonSingle
			// 
			this.radioButtonSingle.AutoSize = true;
			this.radioButtonSingle.Location = new System.Drawing.Point(12, 65);
			this.radioButtonSingle.Name = "radioButtonSingle";
			this.radioButtonSingle.Size = new System.Drawing.Size(161, 17);
			this.radioButtonSingle.TabIndex = 2;
			this.radioButtonSingle.Text = "Single (all files are combined)";
			this.radioButtonSingle.UseVisualStyleBackColor = true;
			// 
			// radioButtonFull
			// 
			this.radioButtonFull.AutoSize = true;
			this.radioButtonFull.Checked = true;
			this.radioButtonFull.Location = new System.Drawing.Point(12, 19);
			this.radioButtonFull.Name = "radioButtonFull";
			this.radioButtonFull.Size = new System.Drawing.Size(205, 17);
			this.radioButtonFull.TabIndex = 0;
			this.radioButtonFull.TabStop = true;
			this.radioButtonFull.Text = "Full (all files separately, recommended)";
			this.radioButtonFull.UseVisualStyleBackColor = true;
			// 
			// radioButtonCompact
			// 
			this.radioButtonCompact.AutoSize = true;
			this.radioButtonCompact.Location = new System.Drawing.Point(12, 42);
			this.radioButtonCompact.Name = "radioButtonCompact";
			this.radioButtonCompact.Size = new System.Drawing.Size(210, 17);
			this.radioButtonCompact.TabIndex = 1;
			this.radioButtonCompact.Text = "Compact (files in a folder are combined)";
			this.radioButtonCompact.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Location = new System.Drawing.Point(208, 199);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Processed: 0 MB";
			// 
			// checkBoxIgnoreHiddenFiles
			// 
			this.checkBoxIgnoreHiddenFiles.AutoSize = true;
			this.checkBoxIgnoreHiddenFiles.Checked = true;
			this.checkBoxIgnoreHiddenFiles.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxIgnoreHiddenFiles.Location = new System.Drawing.Point(12, 168);
			this.checkBoxIgnoreHiddenFiles.Name = "checkBoxIgnoreHiddenFiles";
			this.checkBoxIgnoreHiddenFiles.Size = new System.Drawing.Size(146, 17);
			this.checkBoxIgnoreHiddenFiles.TabIndex = 10;
			this.checkBoxIgnoreHiddenFiles.Text = "Ignore files starting with \'.\'";
			this.checkBoxIgnoreHiddenFiles.UseVisualStyleBackColor = true;
			// 
			// buttonCompare
			// 
			this.buttonCompare.Location = new System.Drawing.Point(12, 12);
			this.buttonCompare.Name = "buttonCompare";
			this.buttonCompare.Size = new System.Drawing.Size(144, 23);
			this.buttonCompare.TabIndex = 11;
			this.buttonCompare.Text = "Compare saved files...";
			this.buttonCompare.UseVisualStyleBackColor = true;
			this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowse.Image = global::TreeHash.Properties.Resources.openHS;
			this.buttonBrowse.Location = new System.Drawing.Point(422, 39);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(23, 23);
			this.buttonBrowse.TabIndex = 6;
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// checkBoxIgnoreFileErrors
			// 
			this.checkBoxIgnoreFileErrors.AutoSize = true;
			this.checkBoxIgnoreFileErrors.Checked = true;
			this.checkBoxIgnoreFileErrors.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxIgnoreFileErrors.Location = new System.Drawing.Point(188, 168);
			this.checkBoxIgnoreFileErrors.Name = "checkBoxIgnoreFileErrors";
			this.checkBoxIgnoreFileErrors.Size = new System.Drawing.Size(138, 17);
			this.checkBoxIgnoreFileErrors.TabIndex = 12;
			this.checkBoxIgnoreFileErrors.Text = "Ignore file access errors";
			this.checkBoxIgnoreFileErrors.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(457, 234);
			this.Controls.Add(this.checkBoxIgnoreFileErrors);
			this.Controls.Add(this.buttonCompare);
			this.Controls.Add(this.checkBoxIgnoreHiddenFiles);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.textBoxSelectedDirectory);
			this.Controls.Add(this.buttonHash);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Tree hasher";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton radioButtonMD5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonHash;
		private System.Windows.Forms.TextBox textBoxSelectedDirectory;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButtonFull;
		private System.Windows.Forms.RadioButton radioButtonCompact;
		private System.Windows.Forms.RadioButton radioButtonSingle;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton radioButtonSHA256;
		private System.Windows.Forms.CheckBox checkBoxIgnoreHiddenFiles;
		private System.Windows.Forms.Button buttonCompare;
		private System.Windows.Forms.CheckBox checkBoxIgnoreFileErrors;
	}
}

