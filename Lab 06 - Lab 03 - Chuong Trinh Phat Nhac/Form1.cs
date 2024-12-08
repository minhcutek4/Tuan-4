using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_06___Lab_03___Chuong_Trinh_Phat_Nhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String s = "Hôm nay là ngày " + DateTime.Now.ToString("dd/MM/yyyy");
            s = s + "  - Bây giờ là " + DateTime.Now.ToString("hh:mm:ss tt");
            toolStripStatusLabel1.Text = s;
            this.Text = this.Text.Substring(1, this.Text.Length - 1) + this.Text.Substring(0, 1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "AVI Files (*.avi)|*.avi|MPEG Files (*.mpeg)|*.mpeg|WAV Files (*.wav)|*.wav|MIDI Files (*.midi)|*.midi|MP4 Files (*.mp4)|*.mp4|All files (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = dlg.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
