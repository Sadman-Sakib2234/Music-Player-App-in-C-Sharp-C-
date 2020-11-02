using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        // Global Variables of path and titles
        String[] paths, files;

        private void selectSong_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            // Select multiple files

            ofd.Multiselect = true;

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;

                // Displaying The titles in listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Code to play music
            axWindowsMediaMusicPlayer.URL = paths[listBoxSongs.SelectedIndex];

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
