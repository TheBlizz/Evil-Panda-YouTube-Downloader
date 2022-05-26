namespace YouTube_Downloader_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnAudio = new System.Windows.Forms.Button();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "YouTube Link";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(15, 25);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(304, 20);
            this.txtURL.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 51);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(95, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Download";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.pictureBox1);
            this.pnlControls.Controls.Add(this.imgVideo);
            this.pnlControls.Controls.Add(this.btnAudio);
            this.pnlControls.Controls.Add(this.btnVideo);
            this.pnlControls.Controls.Add(this.lblTime);
            this.pnlControls.Controls.Add(this.lblAuthor);
            this.pnlControls.Controls.Add(this.lblTitle);
            this.pnlControls.Location = new System.Drawing.Point(5, 80);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(317, 214);
            this.pnlControls.TabIndex = 3;
            this.pnlControls.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(69, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title of Video";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(7, 27);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(80, 13);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author of Video";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(7, 40);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(82, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Length of Video";
            // 
            // btnVideo
            // 
            this.btnVideo.Location = new System.Drawing.Point(10, 56);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(95, 23);
            this.btnVideo.TabIndex = 3;
            this.btnVideo.Text = "Save As Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // btnAudio
            // 
            this.btnAudio.Location = new System.Drawing.Point(10, 85);
            this.btnAudio.Name = "btnAudio";
            this.btnAudio.Size = new System.Drawing.Size(95, 23);
            this.btnAudio.TabIndex = 4;
            this.btnAudio.Text = "Save As Audio";
            this.btnAudio.UseVisualStyleBackColor = true;
            this.btnAudio.Click += new System.EventHandler(this.btnAudio_Click);
            // 
            // imgVideo
            // 
            this.imgVideo.Location = new System.Drawing.Point(111, 14);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(203, 197);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVideo.TabIndex = 5;
            this.imgVideo.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 297);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(272, 17);
            this.lblStatus.Text = "Type in the YouTube link and press Start Download";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 319);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evil Panda YouTube Downloader";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button btnAudio;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

