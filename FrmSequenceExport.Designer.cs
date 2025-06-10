namespace batch_image_editor
{
    partial class FrmSequenceExport
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
            this.btnExport = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblfileName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(496, 31);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(72, 7);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(377, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // lblfileName
            // 
            this.lblfileName.AutoSize = true;
            this.lblfileName.Location = new System.Drawing.Point(12, 10);
            this.lblfileName.Name = "lblfileName";
            this.lblfileName.Size = new System.Drawing.Size(54, 13);
            this.lblfileName.TabIndex = 5;
            this.lblfileName.Text = "File Name";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(15, 36);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(475, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Click Export to Start";
            // 
            // FrmSequenceExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 61);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblfileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnExport);
            this.MinimumSize = new System.Drawing.Size(600, 100);
            this.Name = "FrmSequenceExport";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sequence Export";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblfileName;
        private System.Windows.Forms.Label lblStatus;
    }
}