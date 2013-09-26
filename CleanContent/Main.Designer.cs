namespace CleanContent
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnKeepNewest = new System.Windows.Forms.Button();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.btnDeleteAll = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Location = new System.Drawing.Point(12, 12);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(453, 20);
			this.txtPath.TabIndex = 0;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(471, 10);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(28, 23);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnKeepNewest
			// 
			this.btnKeepNewest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.btnKeepNewest.Location = new System.Drawing.Point(151, 38);
			this.btnKeepNewest.Name = "btnKeepNewest";
			this.btnKeepNewest.Size = new System.Drawing.Size(88, 23);
			this.btnKeepNewest.TabIndex = 2;
			this.btnKeepNewest.Text = "Keep Newest";
			this.btnKeepNewest.UseVisualStyleBackColor = true;
			this.btnKeepNewest.Click += new System.EventHandler(this.btnKeepNewest_Click);
			// 
			// txtOutput
			// 
			this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
							| System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutput.Location = new System.Drawing.Point(12, 67);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.Size = new System.Drawing.Size(487, 164);
			this.txtOutput.TabIndex = 3;
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
							| System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteAll.Location = new System.Drawing.Point(275, 38);
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Size = new System.Drawing.Size(88, 23);
			this.btnDeleteAll.TabIndex = 4;
			this.btnDeleteAll.Text = "Delete All";
			this.btnDeleteAll.UseVisualStyleBackColor = true;
			this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(514, 243);
			this.Controls.Add(this.btnDeleteAll);
			this.Controls.Add(this.txtOutput);
			this.Controls.Add(this.btnKeepNewest);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtPath);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clear flexsimcontent";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnKeepNewest;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnDeleteAll;
	}
}

