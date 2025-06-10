namespace batch_image_editor
{
    partial class Main
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asQuiltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbMainImage = new System.Windows.Forms.PictureBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountText = new System.Windows.Forms.Label();
            this.grpCrop = new System.Windows.Forms.GroupBox();
            this.grpTransform = new System.Windows.Forms.GroupBox();
            this.nudTranslateY = new System.Windows.Forms.NumericUpDown();
            this.nudTranslateX = new System.Windows.Forms.NumericUpDown();
            this.lblTPosX = new System.Windows.Forms.Label();
            this.lblTPosY = new System.Windows.Forms.Label();
            this.lblRatioCalc = new System.Windows.Forms.Label();
            this.lblRatioText = new System.Windows.Forms.Label();
            this.nudCropHeight = new System.Windows.Forms.NumericUpDown();
            this.nudCropYPos = new System.Windows.Forms.NumericUpDown();
            this.nudCropWidth = new System.Windows.Forms.NumericUpDown();
            this.lblCropHright = new System.Windows.Forms.Label();
            this.nudCropXPos = new System.Windows.Forms.NumericUpDown();
            this.lblCropWidth = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.grpScale = new System.Windows.Forms.GroupBox();
            this.lblRatioCalcScale = new System.Windows.Forms.Label();
            this.lblRatioScaleText = new System.Windows.Forms.Label();
            this.cboPresets = new System.Windows.Forms.ComboBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.grpCrop.SuspendLayout();
            this.grpTransform.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranslateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranslateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropYPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropXPos)).BeginInit();
            this.grpScale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(10, 10);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(764, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openImagesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openImagesToolStripMenuItem
            // 
            this.openImagesToolStripMenuItem.Name = "openImagesToolStripMenuItem";
            this.openImagesToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openImagesToolStripMenuItem.Text = "Open";
            this.openImagesToolStripMenuItem.Click += new System.EventHandler(this.openImagesToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asImagesToolStripMenuItem,
            this.asQuiltToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // asImagesToolStripMenuItem
            // 
            this.asImagesToolStripMenuItem.Name = "asImagesToolStripMenuItem";
            this.asImagesToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.asImagesToolStripMenuItem.Text = "As Images";
            this.asImagesToolStripMenuItem.Click += new System.EventHandler(this.asImagesToolStripMenuItem_Click);
            // 
            // asQuiltToolStripMenuItem
            // 
            this.asQuiltToolStripMenuItem.Name = "asQuiltToolStripMenuItem";
            this.asQuiltToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.asQuiltToolStripMenuItem.Text = "As quilt";
            this.asQuiltToolStripMenuItem.Click += new System.EventHandler(this.asQuiltToolStripMenuItem_Click);
            // 
            // pbMainImage
            // 
            this.pbMainImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMainImage.Location = new System.Drawing.Point(0, 0);
            this.pbMainImage.Name = "pbMainImage";
            this.pbMainImage.Size = new System.Drawing.Size(460, 589);
            this.pbMainImage.TabIndex = 2;
            this.pbMainImage.TabStop = false;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(10, 34);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lblCount);
            this.scMain.Panel1.Controls.Add(this.lblCountText);
            this.scMain.Panel1.Controls.Add(this.grpCrop);
            this.scMain.Panel1.Controls.Add(this.lstBox);
            this.scMain.Panel1.Controls.Add(this.grpScale);
            this.scMain.Panel1MinSize = 300;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pbMainImage);
            this.scMain.Size = new System.Drawing.Size(764, 589);
            this.scMain.SplitterDistance = 300;
            this.scMain.TabIndex = 3;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(48, 167);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "0";
            // 
            // lblCountText
            // 
            this.lblCountText.AutoSize = true;
            this.lblCountText.Location = new System.Drawing.Point(7, 167);
            this.lblCountText.Name = "lblCountText";
            this.lblCountText.Size = new System.Drawing.Size(35, 13);
            this.lblCountText.TabIndex = 3;
            this.lblCountText.Text = "Count";
            // 
            // grpCrop
            // 
            this.grpCrop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCrop.Controls.Add(this.grpTransform);
            this.grpCrop.Controls.Add(this.lblRatioCalc);
            this.grpCrop.Controls.Add(this.lblRatioText);
            this.grpCrop.Controls.Add(this.nudCropHeight);
            this.grpCrop.Controls.Add(this.nudCropYPos);
            this.grpCrop.Controls.Add(this.nudCropWidth);
            this.grpCrop.Controls.Add(this.lblCropHright);
            this.grpCrop.Controls.Add(this.nudCropXPos);
            this.grpCrop.Controls.Add(this.lblCropWidth);
            this.grpCrop.Controls.Add(this.lblPosY);
            this.grpCrop.Controls.Add(this.lblPosX);
            this.grpCrop.Location = new System.Drawing.Point(10, 190);
            this.grpCrop.Name = "grpCrop";
            this.grpCrop.Size = new System.Drawing.Size(281, 257);
            this.grpCrop.TabIndex = 1;
            this.grpCrop.TabStop = false;
            this.grpCrop.Text = "Crop";
            // 
            // grpTransform
            // 
            this.grpTransform.Controls.Add(this.nudTranslateY);
            this.grpTransform.Controls.Add(this.nudTranslateX);
            this.grpTransform.Controls.Add(this.lblTPosX);
            this.grpTransform.Controls.Add(this.lblTPosY);
            this.grpTransform.Location = new System.Drawing.Point(6, 168);
            this.grpTransform.Name = "grpTransform";
            this.grpTransform.Size = new System.Drawing.Size(269, 83);
            this.grpTransform.TabIndex = 2;
            this.grpTransform.TabStop = false;
            this.grpTransform.Text = "Transform per frame (px)";
            // 
            // nudTranslateY
            // 
            this.nudTranslateY.Location = new System.Drawing.Point(61, 52);
            this.nudTranslateY.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTranslateY.Name = "nudTranslateY";
            this.nudTranslateY.Size = new System.Drawing.Size(120, 20);
            this.nudTranslateY.TabIndex = 10;
            this.nudTranslateY.ValueChanged += new System.EventHandler(this.nudTranslateY_ValueChanged);
            // 
            // nudTranslateX
            // 
            this.nudTranslateX.Location = new System.Drawing.Point(61, 19);
            this.nudTranslateX.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTranslateX.Name = "nudTranslateX";
            this.nudTranslateX.Size = new System.Drawing.Size(120, 20);
            this.nudTranslateX.TabIndex = 9;
            this.nudTranslateX.ValueChanged += new System.EventHandler(this.nudTranslateX_ValueChanged);
            // 
            // lblTPosX
            // 
            this.lblTPosX.AutoSize = true;
            this.lblTPosX.Location = new System.Drawing.Point(13, 21);
            this.lblTPosX.Margin = new System.Windows.Forms.Padding(10);
            this.lblTPosX.Name = "lblTPosX";
            this.lblTPosX.Size = new System.Drawing.Size(35, 13);
            this.lblTPosX.TabIndex = 8;
            this.lblTPosX.Text = "Pos X";
            // 
            // lblTPosY
            // 
            this.lblTPosY.AutoSize = true;
            this.lblTPosY.Location = new System.Drawing.Point(13, 54);
            this.lblTPosY.Margin = new System.Windows.Forms.Padding(10);
            this.lblTPosY.Name = "lblTPosY";
            this.lblTPosY.Size = new System.Drawing.Size(35, 13);
            this.lblTPosY.TabIndex = 7;
            this.lblTPosY.Text = "Pos Y";
            // 
            // lblRatioCalc
            // 
            this.lblRatioCalc.AutoSize = true;
            this.lblRatioCalc.Location = new System.Drawing.Point(227, 100);
            this.lblRatioCalc.Name = "lblRatioCalc";
            this.lblRatioCalc.Size = new System.Drawing.Size(0, 13);
            this.lblRatioCalc.TabIndex = 6;
            // 
            // lblRatioText
            // 
            this.lblRatioText.AutoSize = true;
            this.lblRatioText.Location = new System.Drawing.Point(188, 100);
            this.lblRatioText.Name = "lblRatioText";
            this.lblRatioText.Size = new System.Drawing.Size(32, 13);
            this.lblRatioText.TabIndex = 5;
            this.lblRatioText.Text = "Ratio";
            // 
            // nudCropHeight
            // 
            this.nudCropHeight.Location = new System.Drawing.Point(61, 129);
            this.nudCropHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCropHeight.Name = "nudCropHeight";
            this.nudCropHeight.Size = new System.Drawing.Size(120, 20);
            this.nudCropHeight.TabIndex = 4;
            this.nudCropHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCropHeight.ValueChanged += new System.EventHandler(this.nudCropHeight_ValueChanged);
            // 
            // nudCropYPos
            // 
            this.nudCropYPos.Location = new System.Drawing.Point(61, 57);
            this.nudCropYPos.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCropYPos.Name = "nudCropYPos";
            this.nudCropYPos.Size = new System.Drawing.Size(120, 20);
            this.nudCropYPos.TabIndex = 2;
            this.nudCropYPos.ValueChanged += new System.EventHandler(this.nudYPos_ValueChanged);
            // 
            // nudCropWidth
            // 
            this.nudCropWidth.Location = new System.Drawing.Point(61, 94);
            this.nudCropWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCropWidth.Name = "nudCropWidth";
            this.nudCropWidth.Size = new System.Drawing.Size(120, 20);
            this.nudCropWidth.TabIndex = 3;
            this.nudCropWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCropWidth.ValueChanged += new System.EventHandler(this.nudCropWidth_ValueChanged);
            // 
            // lblCropHright
            // 
            this.lblCropHright.AutoSize = true;
            this.lblCropHright.Location = new System.Drawing.Point(13, 129);
            this.lblCropHright.Margin = new System.Windows.Forms.Padding(10);
            this.lblCropHright.Name = "lblCropHright";
            this.lblCropHright.Size = new System.Drawing.Size(38, 13);
            this.lblCropHright.TabIndex = 0;
            this.lblCropHright.Text = "Height";
            // 
            // nudCropXPos
            // 
            this.nudCropXPos.Location = new System.Drawing.Point(61, 24);
            this.nudCropXPos.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudCropXPos.Name = "nudCropXPos";
            this.nudCropXPos.Size = new System.Drawing.Size(120, 20);
            this.nudCropXPos.TabIndex = 1;
            this.nudCropXPos.ValueChanged += new System.EventHandler(this.nudXPos_ValueChanged);
            // 
            // lblCropWidth
            // 
            this.lblCropWidth.AutoSize = true;
            this.lblCropWidth.Location = new System.Drawing.Point(13, 96);
            this.lblCropWidth.Margin = new System.Windows.Forms.Padding(10);
            this.lblCropWidth.Name = "lblCropWidth";
            this.lblCropWidth.Size = new System.Drawing.Size(35, 13);
            this.lblCropWidth.TabIndex = 0;
            this.lblCropWidth.Text = "Width";
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(13, 59);
            this.lblPosY.Margin = new System.Windows.Forms.Padding(10);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.Size = new System.Drawing.Size(35, 13);
            this.lblPosY.TabIndex = 0;
            this.lblPosY.Text = "Pos Y";
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(13, 26);
            this.lblPosX.Margin = new System.Windows.Forms.Padding(10);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.Size = new System.Drawing.Size(35, 13);
            this.lblPosX.TabIndex = 0;
            this.lblPosX.Text = "Pos X";
            // 
            // lstBox
            // 
            this.lstBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(10, 10);
            this.lstBox.Margin = new System.Windows.Forms.Padding(10);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(281, 147);
            this.lstBox.TabIndex = 0;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // grpScale
            // 
            this.grpScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpScale.Controls.Add(this.lblRatioCalcScale);
            this.grpScale.Controls.Add(this.lblRatioScaleText);
            this.grpScale.Controls.Add(this.cboPresets);
            this.grpScale.Controls.Add(this.nudHeight);
            this.grpScale.Controls.Add(this.lblHeight);
            this.grpScale.Controls.Add(this.nudWidth);
            this.grpScale.Controls.Add(this.lblWidth);
            this.grpScale.Location = new System.Drawing.Point(10, 453);
            this.grpScale.Name = "grpScale";
            this.grpScale.Size = new System.Drawing.Size(281, 119);
            this.grpScale.TabIndex = 3;
            this.grpScale.TabStop = false;
            this.grpScale.Text = "Size to scale after Crop (px)";
            // 
            // lblRatioCalcScale
            // 
            this.lblRatioCalcScale.AutoSize = true;
            this.lblRatioCalcScale.Location = new System.Drawing.Point(225, 52);
            this.lblRatioCalcScale.Name = "lblRatioCalcScale";
            this.lblRatioCalcScale.Size = new System.Drawing.Size(0, 13);
            this.lblRatioCalcScale.TabIndex = 7;
            // 
            // lblRatioScaleText
            // 
            this.lblRatioScaleText.AutoSize = true;
            this.lblRatioScaleText.Location = new System.Drawing.Point(187, 52);
            this.lblRatioScaleText.Name = "lblRatioScaleText";
            this.lblRatioScaleText.Size = new System.Drawing.Size(32, 13);
            this.lblRatioScaleText.TabIndex = 7;
            this.lblRatioScaleText.Text = "Ratio";
            // 
            // cboPresets
            // 
            this.cboPresets.FormattingEnabled = true;
            this.cboPresets.Location = new System.Drawing.Point(6, 23);
            this.cboPresets.Name = "cboPresets";
            this.cboPresets.Size = new System.Drawing.Size(269, 21);
            this.cboPresets.TabIndex = 1;
            this.cboPresets.SelectedIndexChanged += new System.EventHandler(this.cboPresets_SelectedIndexChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(61, 85);
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 20);
            this.nudHeight.TabIndex = 3;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 85);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(10);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(61, 50);
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 2;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(13, 52);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(10);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 633);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.menuStrip2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Image Editor";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).EndInit();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.grpCrop.ResumeLayout(false);
            this.grpCrop.PerformLayout();
            this.grpTransform.ResumeLayout(false);
            this.grpTransform.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranslateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTranslateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropYPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCropXPos)).EndInit();
            this.grpScale.ResumeLayout(false);
            this.grpScale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.PictureBox pbMainImage;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImagesToolStripMenuItem;
        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asQuiltToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpScale;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.GroupBox grpCrop;
        private System.Windows.Forms.NumericUpDown nudCropYPos;
        private System.Windows.Forms.NumericUpDown nudCropXPos;
        private System.Windows.Forms.Label lblPosY;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.NumericUpDown nudCropHeight;
        private System.Windows.Forms.NumericUpDown nudCropWidth;
        private System.Windows.Forms.Label lblCropHright;
        private System.Windows.Forms.Label lblCropWidth;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCountText;
        private System.Windows.Forms.Label lblRatioText;
        private System.Windows.Forms.Label lblRatioCalc;
        private System.Windows.Forms.ComboBox cboPresets;
        private System.Windows.Forms.Label lblRatioCalcScale;
        private System.Windows.Forms.Label lblRatioScaleText;
        private System.Windows.Forms.GroupBox grpTransform;
        private System.Windows.Forms.NumericUpDown nudTranslateY;
        private System.Windows.Forms.NumericUpDown nudTranslateX;
        private System.Windows.Forms.Label lblTPosX;
        private System.Windows.Forms.Label lblTPosY;
    }
}

