namespace MusicPlayerApp
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.selectSong = new System.Windows.Forms.Button();
            this.axWindowsMediaMusicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.devlevel = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaMusicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Ivory;
            this.toppanel.Controls.Add(this.pictureBox1);
            this.toppanel.Controls.Add(this.logo);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(712, 68);
            this.toppanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("WhatnotW00-Italic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(43, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(192, 47);
            this.logo.TabIndex = 0;
            this.logo.Text = "MusicPlayer";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 24;
            this.listBoxSongs.Location = new System.Drawing.Point(520, 74);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(180, 220);
            this.listBoxSongs.TabIndex = 1;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // selectSong
            // 
            this.selectSong.BackColor = System.Drawing.Color.Red;
            this.selectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectSong.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSong.ForeColor = System.Drawing.Color.White;
            this.selectSong.Location = new System.Drawing.Point(520, 315);
            this.selectSong.Name = "selectSong";
            this.selectSong.Size = new System.Drawing.Size(180, 44);
            this.selectSong.TabIndex = 2;
            this.selectSong.Text = "Select";
            this.selectSong.UseVisualStyleBackColor = false;
            this.selectSong.Click += new System.EventHandler(this.selectSong_Click);
            // 
            // axWindowsMediaMusicPlayer
            // 
            this.axWindowsMediaMusicPlayer.Enabled = true;
            this.axWindowsMediaMusicPlayer.Location = new System.Drawing.Point(12, 74);
            this.axWindowsMediaMusicPlayer.Name = "axWindowsMediaMusicPlayer";
            this.axWindowsMediaMusicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaMusicPlayer.OcxState")));
            this.axWindowsMediaMusicPlayer.Size = new System.Drawing.Size(487, 285);
            this.axWindowsMediaMusicPlayer.TabIndex = 3;
            // 
            // devlevel
            // 
            this.devlevel.AutoSize = true;
            this.devlevel.Font = new System.Drawing.Font("DK Display Patrol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devlevel.ForeColor = System.Drawing.Color.White;
            this.devlevel.Location = new System.Drawing.Point(241, 368);
            this.devlevel.Name = "devlevel";
            this.devlevel.Size = new System.Drawing.Size(258, 22);
            this.devlevel.TabIndex = 5;
            this.devlevel.Text = "Developed By- Sadman Sakib";
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(712, 399);
            this.Controls.Add(this.devlevel);
            this.Controls.Add(this.axWindowsMediaMusicPlayer);
            this.Controls.Add(this.selectSong);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlayerApp";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaMusicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button selectSong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaMusicPlayer;
        private System.Windows.Forms.Label devlevel;
    }
}

