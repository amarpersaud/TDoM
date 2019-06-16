namespace TDoM
{
    partial class MainWindow
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
            this.musicBackButton = new System.Windows.Forms.Button();
            this.musicPlayButton = new System.Windows.Forms.Button();
            this.musicSkipButton = new System.Windows.Forms.Button();
            this.musicVolume = new System.Windows.Forms.TrackBar();
            this.musicTrackBar = new TDoM.Controls.ProgressTrackBar();
            this.musicElapsedTimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // musicBackButton
            // 
            this.musicBackButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.musicBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicBackButton.Location = new System.Drawing.Point(329, 491);
            this.musicBackButton.Name = "musicBackButton";
            this.musicBackButton.Size = new System.Drawing.Size(75, 56);
            this.musicBackButton.TabIndex = 0;
            this.musicBackButton.Text = "⯇⯇ ";
            this.musicBackButton.UseVisualStyleBackColor = true;
            // 
            // musicPlayButton
            // 
            this.musicPlayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.musicPlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicPlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicPlayButton.Location = new System.Drawing.Point(410, 491);
            this.musicPlayButton.Name = "musicPlayButton";
            this.musicPlayButton.Size = new System.Drawing.Size(75, 56);
            this.musicPlayButton.TabIndex = 1;
            this.musicPlayButton.Text = "▶";
            this.musicPlayButton.UseVisualStyleBackColor = true;
            this.musicPlayButton.Click += new System.EventHandler(this.musicPlayButton_ClickAsync);
            // 
            // musicSkipButton
            // 
            this.musicSkipButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.musicSkipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicSkipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicSkipButton.Location = new System.Drawing.Point(491, 491);
            this.musicSkipButton.Name = "musicSkipButton";
            this.musicSkipButton.Size = new System.Drawing.Size(75, 56);
            this.musicSkipButton.TabIndex = 2;
            this.musicSkipButton.Text = "⯈⯈";
            this.musicSkipButton.UseVisualStyleBackColor = true;
            // 
            // musicVolume
            // 
            this.musicVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.musicVolume.Location = new System.Drawing.Point(573, 492);
            this.musicVolume.Maximum = 100;
            this.musicVolume.Name = "musicVolume";
            this.musicVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.musicVolume.Size = new System.Drawing.Size(310, 56);
            this.musicVolume.TabIndex = 5;
            this.musicVolume.TickFrequency = 25;
            this.musicVolume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.musicVolume.Value = 75;
            this.musicVolume.ValueChanged += new System.EventHandler(this.musicVolume_ValueChanged);
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musicTrackBar.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.musicTrackBar.BarPrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.musicTrackBar.BarPrimaryShadowColor = System.Drawing.Color.Green;
            this.musicTrackBar.BarShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.musicTrackBar.Location = new System.Drawing.Point(12, 454);
            this.musicTrackBar.Maximum = 10000;
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(871, 32);
            this.musicTrackBar.TabIndex = 6;
            this.musicTrackBar.Text = "progressTrackBar1";
            this.musicTrackBar.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.musicTrackBar.ThumbCenterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.musicTrackBar.ThumbColor = System.Drawing.Color.Silver;
            this.musicTrackBar.ThumbShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.musicTrackBar.ThumbSize = new System.Drawing.Size(18, 18);
            // 
            // musicElapsedTimeLabel
            // 
            this.musicElapsedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.musicElapsedTimeLabel.AutoSize = true;
            this.musicElapsedTimeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicElapsedTimeLabel.Location = new System.Drawing.Point(25, 506);
            this.musicElapsedTimeLabel.Name = "musicElapsedTimeLabel";
            this.musicElapsedTimeLabel.Size = new System.Drawing.Size(94, 27);
            this.musicElapsedTimeLabel.TabIndex = 7;
            this.musicElapsedTimeLabel.Text = "00:00:00";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 559);
            this.Controls.Add(this.musicElapsedTimeLabel);
            this.Controls.Add(this.musicTrackBar);
            this.Controls.Add(this.musicVolume);
            this.Controls.Add(this.musicSkipButton);
            this.Controls.Add(this.musicPlayButton);
            this.Controls.Add(this.musicBackButton);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Text = "TDoM";
            ((System.ComponentModel.ISupportInitialize)(this.musicVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musicBackButton;
        private System.Windows.Forms.Button musicPlayButton;
        private System.Windows.Forms.Button musicSkipButton;
        private System.Windows.Forms.TrackBar musicVolume;
        private Controls.ProgressTrackBar musicTrackBar;
        private System.Windows.Forms.Label musicElapsedTimeLabel;
    }
}