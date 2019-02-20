namespace TDoM
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchArtistsCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchAlbumsCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchTracksCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButtonClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 22);
            this.textBox1.TabIndex = 1;
            // 
            // SearchArtistsCheckBox
            // 
            this.SearchArtistsCheckBox.AutoSize = true;
            this.SearchArtistsCheckBox.Checked = true;
            this.SearchArtistsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchArtistsCheckBox.Location = new System.Drawing.Point(13, 41);
            this.SearchArtistsCheckBox.Name = "SearchArtistsCheckBox";
            this.SearchArtistsCheckBox.Size = new System.Drawing.Size(69, 21);
            this.SearchArtistsCheckBox.TabIndex = 2;
            this.SearchArtistsCheckBox.Text = "Artists";
            this.SearchArtistsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchAlbumsCheckBox
            // 
            this.SearchAlbumsCheckBox.AutoSize = true;
            this.SearchAlbumsCheckBox.Checked = true;
            this.SearchAlbumsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchAlbumsCheckBox.Location = new System.Drawing.Point(88, 41);
            this.SearchAlbumsCheckBox.Name = "SearchAlbumsCheckBox";
            this.SearchAlbumsCheckBox.Size = new System.Drawing.Size(76, 21);
            this.SearchAlbumsCheckBox.TabIndex = 3;
            this.SearchAlbumsCheckBox.Text = "Albums";
            this.SearchAlbumsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchTracksCheckBox
            // 
            this.SearchTracksCheckBox.AutoSize = true;
            this.SearchTracksCheckBox.Checked = true;
            this.SearchTracksCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchTracksCheckBox.Location = new System.Drawing.Point(170, 41);
            this.SearchTracksCheckBox.Name = "SearchTracksCheckBox";
            this.SearchTracksCheckBox.Size = new System.Drawing.Size(73, 21);
            this.SearchTracksCheckBox.TabIndex = 4;
            this.SearchTracksCheckBox.Text = "Tracks";
            this.SearchTracksCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 481);
            this.Controls.Add(this.SearchTracksCheckBox);
            this.Controls.Add(this.SearchAlbumsCheckBox);
            this.Controls.Add(this.SearchArtistsCheckBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox SearchArtistsCheckBox;
        private System.Windows.Forms.CheckBox SearchAlbumsCheckBox;
        private System.Windows.Forms.CheckBox SearchTracksCheckBox;
    }
}

