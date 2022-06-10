using System;
using System.Windows.Forms;
using System.Drawing;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private System.Media.SoundPlayer _player = new System.Media.SoundPlayer();

        public MainForm()
        {
            InitializeComponent();

            _player.SoundLocation = @"D:\учеба\2 sem\programming\lab3\src\Source\Sound\ost.wav";
            MusicCheckBox.Checked = true;
        }

        private void MusicCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MusicCheckBox.Checked)
                _player.Play();
            else
                _player.Stop();
        }
    }
}
