namespace TreeHash
{
	partial class CompareWindow
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
			this.textBoxFile1 = new System.Windows.Forms.TextBox();
			this.buttonBrowse1 = new System.Windows.Forms.Button();
			this.buttonBrowse2 = new System.Windows.Forms.Button();
			this.textBoxFile2 = new System.Windows.Forms.TextBox();
			this.buttonClose = new System.Windows.Forms.Button();
			this.buttonCompare = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxFile1
			// 
			this.textBoxFile1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFile1.Location = new System.Drawing.Point(12, 12);
			this.textBoxFile1.Name = "textBoxFile1";
			this.textBoxFile1.Size = new System.Drawing.Size(356, 20);
			this.textBoxFile1.TabIndex = 7;
			// 
			// buttonBrowse1
			// 
			this.buttonBrowse1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowse1.Image = global::TreeHash.Properties.Resources.openHS;
			this.buttonBrowse1.Location = new System.Drawing.Point(374, 10);
			this.buttonBrowse1.Name = "buttonBrowse1";
			this.buttonBrowse1.Size = new System.Drawing.Size(23, 23);
			this.buttonBrowse1.TabIndex = 8;
			this.buttonBrowse1.UseVisualStyleBackColor = true;
			this.buttonBrowse1.Click += new System.EventHandler(this.buttonBrowse1_Click);
			// 
			// buttonBrowse2
			// 
			this.buttonBrowse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonBrowse2.Image = global::TreeHash.Properties.Resources.openHS;
			this.buttonBrowse2.Location = new System.Drawing.Point(374, 39);
			this.buttonBrowse2.Name = "buttonBrowse2";
			this.buttonBrowse2.Size = new System.Drawing.Size(23, 23);
			this.buttonBrowse2.TabIndex = 10;
			this.buttonBrowse2.UseVisualStyleBackColor = true;
			this.buttonBrowse2.Click += new System.EventHandler(this.buttonBrowse2_Click);
			// 
			// textBoxFile2
			// 
			this.textBoxFile2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFile2.Location = new System.Drawing.Point(12, 41);
			this.textBoxFile2.Name = "textBoxFile2";
			this.textBoxFile2.Size = new System.Drawing.Size(356, 20);
			this.textBoxFile2.TabIndex = 9;
			// 
			// buttonClose
			// 
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.Location = new System.Drawing.Point(322, 78);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(75, 23);
			this.buttonClose.TabIndex = 11;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			// 
			// buttonCompare
			// 
			this.buttonCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCompare.Location = new System.Drawing.Point(241, 78);
			this.buttonCompare.Name = "buttonCompare";
			this.buttonCompare.Size = new System.Drawing.Size(75, 23);
			this.buttonCompare.TabIndex = 12;
			this.buttonCompare.Text = "Compare";
			this.buttonCompare.UseVisualStyleBackColor = true;
			this.buttonCompare.Click += new System.EventHandler(this.buttonCompare_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.Enabled = false;
			this.buttonCancel.Location = new System.Drawing.Point(160, 78);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// CompareWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 113);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonCompare);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonBrowse2);
			this.Controls.Add(this.textBoxFile2);
			this.Controls.Add(this.buttonBrowse1);
			this.Controls.Add(this.textBoxFile1);
			this.Name = "CompareWindow";
			this.Text = "Comparer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonBrowse1;
		private System.Windows.Forms.TextBox textBoxFile1;
		private System.Windows.Forms.Button buttonBrowse2;
		private System.Windows.Forms.TextBox textBoxFile2;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.Button buttonCompare;
		private System.Windows.Forms.Button buttonCancel;
	}
}