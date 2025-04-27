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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboPresets = new System.Windows.Forms.ComboBox();
            this.lblPreset = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nupHeight = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblAspectRatio = new System.Windows.Forms.Label();
            this.lblAspectRatioText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.nudRow = new System.Windows.Forms.NumericUpDown();
            this.nudCol = new System.Windows.Forms.NumericUpDown();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblfileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).BeginInit();
            this.SuspendLayout();
            // 
            // cboPresets
            // 
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
            this.grpSettings.Controls.Add(this.nudWidth);
            this.grpSettings.Controls.Add(this.lblHeight);
            this.grpSettings.Controls.Add(this.nupHeight);
            this.grpSettings.Controls.Add(this.lblWidth);
            this.grpSettings.Controls.Add(this.lblAspectRatio);
            this.grpSettings.Controls.Add(this.lblAspectRatioText);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.lblColumns);
            this.grpSettings.Controls.Add(this.nudRow);
            this.grpSettings.Controls.Add(this.nudCol);
            this.grpSettings.Location = new System.Drawing.Point(16, 48);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(555, 77);
            this.grpSettings.TabIndex = 2;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(243, 45);
            this.nudWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 9;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(369, 47);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 8;
            this.lblHeight.Text = "Height";
            // 
            // nupHeight
            // 
            this.nupHeight.Location = new System.Drawing.Point(413, 45);
            this.nupHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nupHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupHeight.Name = "nupHeight";
            this.nupHeight.Size = new System.Drawing.Size(120, 20);
            this.nupHeight.TabIndex = 7;
            this.nupHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(202, 47);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 6;
            this.lblWidth.Text = "Width";
            // 
            // lblAspectRatio
            // 
            this.lblAspectRatio.AutoSize = true;
            this.lblAspectRatio.Location = new System.Drawing.Point(276, 21);
            this.lblAspectRatio.Name = "lblAspectRatio";
            this.lblAspectRatio.Size = new System.Drawing.Size(0, 13);
            this.lblAspectRatio.TabIndex = 5;
            // 
            // lblAspectRatioText
            // 
            this.lblAspectRatioText.AutoSize = true;
            this.lblAspectRatioText.Location = new System.Drawing.Point(202, 21);
            this.lblAspectRatioText.Name = "lblAspectRatioText";
            this.lblAspectRatioText.Size = new System.Drawing.Size(68, 13);
            this.lblAspectRatioText.TabIndex = 4;
            this.lblAspectRatioText.Text = "Aspect Ratio";
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
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Location = new System.Drawing.Point(496, 131);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(113, 132);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(377, 20);
            this.txtFileName.TabIndex = 4;
            // 
            // lblfileName
            // 
            this.lblfileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfileName.AutoSize = true;
            this.lblfileName.Location = new System.Drawing.Point(53, 135);
            this.lblfileName.Name = "lblfileName";
            this.lblfileName.Size = new System.Drawing.Size(54, 13);
            this.lblfileName.TabIndex = 5;
            this.lblfileName.Text = "File Name";
            // 
            // FrmQuiltExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.lblfileName);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.cboPresets);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "FrmQuiltExport";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Looking Glass Quilt Export";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
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
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.NumericUpDown nupHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
    }
}