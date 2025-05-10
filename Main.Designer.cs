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
            this.nudCropHeight = new System.Windows.Forms.NumericUpDown();
            this.nudCropYPos = new System.Windows.Forms.NumericUpDown();
            this.nudCropWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCropXPos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPosY = new System.Windows.Forms.Label();
            this.lblPosX = new System.Windows.Forms.Label();
            this.grpScale = new System.Windows.Forms.GroupBox();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblRatioText = new System.Windows.Forms.Label();
            this.lblRatioCalc = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.grpCrop.SuspendLayout();
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
            this.pbMainImage.Size = new System.Drawing.Size(460, 517);
            this.pbMainImage.TabIndex = 2;
            this.pbMainImage.TabStop = false;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(10, 34);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lblCount);
            this.scMain.Panel1.Controls.Add(this.lblCountText);
            this.scMain.Panel1.Controls.Add(this.grpCrop);
            this.scMain.Panel1.Controls.Add(this.grpScale);
            this.scMain.Panel1.Controls.Add(this.lstBox);
            this.scMain.Panel1MinSize = 300;
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pbMainImage);
            this.scMain.Size = new System.Drawing.Size(764, 517);
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
            this.grpCrop.Controls.Add(this.lblRatioCalc);
            this.grpCrop.Controls.Add(this.lblRatioText);
            this.grpCrop.Controls.Add(this.nudCropHeight);
            this.grpCrop.Controls.Add(this.nudCropYPos);
            this.grpCrop.Controls.Add(this.nudCropWidth);
            this.grpCrop.Controls.Add(this.label1);
            this.grpCrop.Controls.Add(this.nudCropXPos);
            this.grpCrop.Controls.Add(this.label2);
            this.grpCrop.Controls.Add(this.lblPosY);
            this.grpCrop.Controls.Add(this.lblPosX);
            this.grpCrop.Location = new System.Drawing.Point(10, 190);
            this.grpCrop.Name = "grpCrop";
            this.grpCrop.Size = new System.Drawing.Size(281, 159);
            this.grpCrop.TabIndex = 1;
            this.grpCrop.TabStop = false;
            this.grpCrop.Text = "Crop";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width";
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
            // grpScale
            // 
            this.grpScale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpScale.Controls.Add(this.nudHeight);
            this.grpScale.Controls.Add(this.nudWidth);
            this.grpScale.Controls.Add(this.lblHeight);
            this.grpScale.Controls.Add(this.lblWidth);
            this.grpScale.Location = new System.Drawing.Point(10, 355);
            this.grpScale.Name = "grpScale";
            this.grpScale.Size = new System.Drawing.Size(281, 100);
            this.grpScale.TabIndex = 2;
            this.grpScale.TabStop = false;
            this.grpScale.Text = "Size to scale after Crop (px)";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(61, 59);
            this.nudHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 20);
            this.nudHeight.TabIndex = 2;
            this.nudHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(61, 24);
            this.nudWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 1;
            this.nudWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(13, 59);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(10);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(13, 26);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(10);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Width";
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
            // lblRatioText
            // 
            this.lblRatioText.AutoSize = true;
            this.lblRatioText.Location = new System.Drawing.Point(188, 100);
            this.lblRatioText.Name = "lblRatioText";
            this.lblRatioText.Size = new System.Drawing.Size(32, 13);
            this.lblRatioText.TabIndex = 5;
            this.lblRatioText.Text = "Ratio";
            // 
            // lblRatioCalc
            // 
            this.lblRatioCalc.AutoSize = true;
            this.lblRatioCalc.Location = new System.Drawing.Point(227, 100);
            this.lblRatioCalc.Name = "lblRatioCalc";
            this.lblRatioCalc.Size = new System.Drawing.Size(0, 13);
            this.lblRatioCalc.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCountText;
        private System.Windows.Forms.Label lblRatioText;
        private System.Windows.Forms.Label lblRatioCalc;
    }
}

