namespace batch_image_editor
{
    partial class FrmQuiltExport
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
            this.cboPresets = new System.Windows.Forms.ComboBox();
            this.lblPreset = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.nudCol = new System.Windows.Forms.NumericUpDown();
            this.lblPresetHeightText = new System.Windows.Forms.Label();
            this.lblPresetWidthText = new System.Windows.Forms.Label();
            this.lblAspectRatio = new System.Windows.Forms.Label();
            this.lblAspectRatioText = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblfileName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpPreset = new System.Windows.Forms.GroupBox();
            this.lblPresetWidth = new System.Windows.Forms.Label();
            this.lblPresetHeight = new System.Windows.Forms.Label();
            this.lblPresetCellHeight = new System.Windows.Forms.Label();
            this.lblPresetCellWidth = new System.Windows.Forms.Label();
            this.lblPresetCellHeightText = new System.Windows.Forms.Label();
            this.lblPresetCellWidthText = new System.Windows.Forms.Label();
            this.grpImageSettings = new System.Windows.Forms.GroupBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblImageCellHeight = new System.Windows.Forms.Label();
            this.lblHeightText = new System.Windows.Forms.Label();
            this.lblImageCellWidth = new System.Windows.Forms.Label();
            this.lblImageCellHeightText = new System.Windows.Forms.Label();
            this.lblWidthText = new System.Windows.Forms.Label();
            this.lblImageCellWidthText = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).BeginInit();
            this.grpPreset.SuspendLayout();
            this.grpImageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPresets
            // 
            this.cboPresets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresets.FormattingEnabled = true;
            this.cboPresets.Location = new System.Drawing.Point(113, 13);
            this.cboPresets.Name = "cboPresets";
            this.cboPresets.Size = new System.Drawing.Size(458, 21);
            this.cboPresets.TabIndex = 0;
            this.cboPresets.SelectedIndexChanged += new System.EventHandler(this.cboPresets_SelectedIndexChanged);
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Location = new System.Drawing.Point(13, 16);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(37, 13);
            this.lblPreset.TabIndex = 1;
            this.lblPreset.Text = "Preset";
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.lblColumns);
            this.grpSettings.Controls.Add(this.nudRow);
            this.grpSettings.Controls.Add(this.nudCol);
            this.grpSettings.Location = new System.Drawing.Point(16, 237);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(555, 83);
            this.grpSettings.TabIndex = 2;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rows";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(6, 21);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(47, 13);
            this.lblColumns.TabIndex = 2;
            this.lblColumns.Text = "Columns";
            // 
            // nudRow
            // 
            this.nudRow.Location = new System.Drawing.Point(59, 45);
            this.nudRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRow.Name = "nudRow";
            this.nudRow.Size = new System.Drawing.Size(120, 20);
            this.nudRow.TabIndex = 1;
            this.nudRow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRow.ValueChanged += new System.EventHandler(this.nudRow_ValueChanged);
            // 
            // nudCol
            // 
            this.nudCol.Location = new System.Drawing.Point(59, 19);
            this.nudCol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCol.Name = "nudCol";
            this.nudCol.Size = new System.Drawing.Size(120, 20);
            this.nudCol.TabIndex = 0;
            this.nudCol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCol.ValueChanged += new System.EventHandler(this.nudCol_ValueChanged);
            // 
            // lblPresetHeightText
            // 
            this.lblPresetHeightText.AutoSize = true;
            this.lblPresetHeightText.Location = new System.Drawing.Point(141, 44);
            this.lblPresetHeightText.Name = "lblPresetHeightText";
            this.lblPresetHeightText.Size = new System.Drawing.Size(65, 13);
            this.lblPresetHeightText.TabIndex = 8;
            this.lblPresetHeightText.Text = "Total Height";
            // 
            // lblPresetWidthText
            // 
            this.lblPresetWidthText.AutoSize = true;
            this.lblPresetWidthText.Location = new System.Drawing.Point(141, 69);
            this.lblPresetWidthText.Name = "lblPresetWidthText";
            this.lblPresetWidthText.Size = new System.Drawing.Size(62, 13);
            this.lblPresetWidthText.TabIndex = 6;
            this.lblPresetWidthText.Text = "Total Width";
            // 
            // lblAspectRatio
            // 
            this.lblAspectRatio.AutoSize = true;
            this.lblAspectRatio.Location = new System.Drawing.Point(80, 20);
            this.lblAspectRatio.Name = "lblAspectRatio";
            this.lblAspectRatio.Size = new System.Drawing.Size(0, 13);
            this.lblAspectRatio.TabIndex = 5;
            // 
            // lblAspectRatioText
            // 
            this.lblAspectRatioText.AutoSize = true;
            this.lblAspectRatioText.Location = new System.Drawing.Point(6, 20);
            this.lblAspectRatioText.Name = "lblAspectRatioText";
            this.lblAspectRatioText.Size = new System.Drawing.Size(68, 13);
            this.lblAspectRatioText.TabIndex = 4;
            this.lblAspectRatioText.Text = "Aspect Ratio";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(496, 381);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(75, 330);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(496, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // lblfileName
            // 
            this.lblfileName.AutoSize = true;
            this.lblfileName.Location = new System.Drawing.Point(15, 333);
            this.lblfileName.Name = "lblfileName";
            this.lblfileName.Size = new System.Drawing.Size(54, 13);
            this.lblfileName.TabIndex = 5;
            this.lblfileName.Text = "File Name";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.Location = new System.Drawing.Point(15, 386);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatus.Size = new System.Drawing.Size(475, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Click Export to Start";
            // 
            // grpPreset
            // 
            this.grpPreset.Controls.Add(this.lblPresetWidth);
            this.grpPreset.Controls.Add(this.lblPresetHeight);
            this.grpPreset.Controls.Add(this.lblAspectRatio);
            this.grpPreset.Controls.Add(this.lblPresetCellHeight);
            this.grpPreset.Controls.Add(this.lblPresetHeightText);
            this.grpPreset.Controls.Add(this.lblPresetCellWidth);
            this.grpPreset.Controls.Add(this.lblPresetCellHeightText);
            this.grpPreset.Controls.Add(this.lblPresetWidthText);
            this.grpPreset.Controls.Add(this.lblPresetCellWidthText);
            this.grpPreset.Controls.Add(this.lblAspectRatioText);
            this.grpPreset.Location = new System.Drawing.Point(13, 40);
            this.grpPreset.Name = "grpPreset";
            this.grpPreset.Size = new System.Drawing.Size(558, 104);
            this.grpPreset.TabIndex = 7;
            this.grpPreset.TabStop = false;
            this.grpPreset.Text = "Preset Settings";
            // 
            // lblPresetWidth
            // 
            this.lblPresetWidth.AutoSize = true;
            this.lblPresetWidth.Location = new System.Drawing.Point(212, 69);
            this.lblPresetWidth.Name = "lblPresetWidth";
            this.lblPresetWidth.Size = new System.Drawing.Size(0, 13);
            this.lblPresetWidth.TabIndex = 10;
            // 
            // lblPresetHeight
            // 
            this.lblPresetHeight.AutoSize = true;
            this.lblPresetHeight.Location = new System.Drawing.Point(212, 44);
            this.lblPresetHeight.Name = "lblPresetHeight";
            this.lblPresetHeight.Size = new System.Drawing.Size(0, 13);
            this.lblPresetHeight.TabIndex = 9;
            // 
            // lblPresetCellHeight
            // 
            this.lblPresetCellHeight.AutoSize = true;
            this.lblPresetCellHeight.Location = new System.Drawing.Point(67, 69);
            this.lblPresetCellHeight.Name = "lblPresetCellHeight";
            this.lblPresetCellHeight.Size = new System.Drawing.Size(0, 13);
            this.lblPresetCellHeight.TabIndex = 3;
            // 
            // lblPresetCellWidth
            // 
            this.lblPresetCellWidth.AutoSize = true;
            this.lblPresetCellWidth.Location = new System.Drawing.Point(67, 44);
            this.lblPresetCellWidth.Name = "lblPresetCellWidth";
            this.lblPresetCellWidth.Size = new System.Drawing.Size(0, 13);
            this.lblPresetCellWidth.TabIndex = 2;
            // 
            // lblPresetCellHeightText
            // 
            this.lblPresetCellHeightText.AutoSize = true;
            this.lblPresetCellHeightText.Location = new System.Drawing.Point(6, 69);
            this.lblPresetCellHeightText.Name = "lblPresetCellHeightText";
            this.lblPresetCellHeightText.Size = new System.Drawing.Size(58, 13);
            this.lblPresetCellHeightText.TabIndex = 1;
            this.lblPresetCellHeightText.Text = "Cell Height";
            // 
            // lblPresetCellWidthText
            // 
            this.lblPresetCellWidthText.AutoSize = true;
            this.lblPresetCellWidthText.Location = new System.Drawing.Point(6, 44);
            this.lblPresetCellWidthText.Name = "lblPresetCellWidthText";
            this.lblPresetCellWidthText.Size = new System.Drawing.Size(55, 13);
            this.lblPresetCellWidthText.TabIndex = 0;
            this.lblPresetCellWidthText.Text = "Cell Width";
            // 
            // grpImageSettings
            // 
            this.grpImageSettings.Controls.Add(this.lblWidth);
            this.grpImageSettings.Controls.Add(this.lblHeight);
            this.grpImageSettings.Controls.Add(this.lblImageCellHeight);
            this.grpImageSettings.Controls.Add(this.lblHeightText);
            this.grpImageSettings.Controls.Add(this.lblImageCellWidth);
            this.grpImageSettings.Controls.Add(this.lblImageCellHeightText);
            this.grpImageSettings.Controls.Add(this.lblWidthText);
            this.grpImageSettings.Controls.Add(this.lblImageCellWidthText);
            this.grpImageSettings.Location = new System.Drawing.Point(13, 150);
            this.grpImageSettings.Name = "grpImageSettings";
            this.grpImageSettings.Size = new System.Drawing.Size(558, 81);
            this.grpImageSettings.TabIndex = 8;
            this.grpImageSettings.TabStop = false;
            this.grpImageSettings.Text = "Selected Settings";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(212, 51);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(0, 13);
            this.lblWidth.TabIndex = 10;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(212, 26);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(0, 13);
            this.lblHeight.TabIndex = 9;
            // 
            // lblImageCellHeight
            // 
            this.lblImageCellHeight.AutoSize = true;
            this.lblImageCellHeight.Location = new System.Drawing.Point(70, 51);
            this.lblImageCellHeight.Name = "lblImageCellHeight";
            this.lblImageCellHeight.Size = new System.Drawing.Size(0, 13);
            this.lblImageCellHeight.TabIndex = 3;
            // 
            // lblHeightText
            // 
            this.lblHeightText.AutoSize = true;
            this.lblHeightText.Location = new System.Drawing.Point(141, 26);
            this.lblHeightText.Name = "lblHeightText";
            this.lblHeightText.Size = new System.Drawing.Size(65, 13);
            this.lblHeightText.TabIndex = 8;
            this.lblHeightText.Text = "Total Height";
            // 
            // lblImageCellWidth
            // 
            this.lblImageCellWidth.AutoSize = true;
            this.lblImageCellWidth.Location = new System.Drawing.Point(70, 26);
            this.lblImageCellWidth.Name = "lblImageCellWidth";
            this.lblImageCellWidth.Size = new System.Drawing.Size(0, 13);
            this.lblImageCellWidth.TabIndex = 2;
            // 
            // lblImageCellHeightText
            // 
            this.lblImageCellHeightText.AutoSize = true;
            this.lblImageCellHeightText.Location = new System.Drawing.Point(9, 51);
            this.lblImageCellHeightText.Name = "lblImageCellHeightText";
            this.lblImageCellHeightText.Size = new System.Drawing.Size(58, 13);
            this.lblImageCellHeightText.TabIndex = 1;
            this.lblImageCellHeightText.Text = "Cell Height";
            // 
            // lblWidthText
            // 
            this.lblWidthText.AutoSize = true;
            this.lblWidthText.Location = new System.Drawing.Point(141, 51);
            this.lblWidthText.Name = "lblWidthText";
            this.lblWidthText.Size = new System.Drawing.Size(62, 13);
            this.lblWidthText.TabIndex = 6;
            this.lblWidthText.Text = "Total Width";
            // 
            // lblImageCellWidthText
            // 
            this.lblImageCellWidthText.AutoSize = true;
            this.lblImageCellWidthText.Location = new System.Drawing.Point(9, 26);
            this.lblImageCellWidthText.Name = "lblImageCellWidthText";
            this.lblImageCellWidthText.Size = new System.Drawing.Size(55, 13);
            this.lblImageCellWidthText.TabIndex = 0;
            this.lblImageCellWidthText.Text = "Cell Width";
            // 
            // FrmQuiltExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.grpImageSettings);
            this.Controls.Add(this.grpPreset);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblfileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.cboPresets);
            this.MaximumSize = new System.Drawing.Size(600, 450);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "FrmQuiltExport";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Looking Glass Quilt Export";
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).EndInit();
            this.grpPreset.ResumeLayout(false);
            this.grpPreset.PerformLayout();
            this.grpImageSettings.ResumeLayout(false);
            this.grpImageSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboPresets;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.NumericUpDown nudRow;
        private System.Windows.Forms.NumericUpDown nudCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblfileName;
        private System.Windows.Forms.Label lblAspectRatioText;
        private System.Windows.Forms.Label lblAspectRatio;
        private System.Windows.Forms.Label lblPresetWidthText;
        private System.Windows.Forms.Label lblPresetHeightText;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpPreset;
        private System.Windows.Forms.Label lblPresetCellHeightText;
        private System.Windows.Forms.Label lblPresetCellWidthText;
        private System.Windows.Forms.Label lblPresetCellHeight;
        private System.Windows.Forms.Label lblPresetCellWidth;
        private System.Windows.Forms.Label lblPresetHeight;
        private System.Windows.Forms.Label lblPresetWidth;
        private System.Windows.Forms.GroupBox grpImageSettings;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblImageCellHeight;
        private System.Windows.Forms.Label lblHeightText;
        private System.Windows.Forms.Label lblImageCellWidth;
        private System.Windows.Forms.Label lblImageCellHeightText;
        private System.Windows.Forms.Label lblWidthText;
        private System.Windows.Forms.Label lblImageCellWidthText;
    }
}