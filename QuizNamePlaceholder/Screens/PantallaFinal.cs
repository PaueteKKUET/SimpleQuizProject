using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace QuizNamePlaceholder.Screens
{
    public partial class PantallaFinal : Form
    {
        SoundPlayer s = new SoundPlayer();

        public PantallaFinal()
        {
            s.SoundLocation = @"Data\MusicaFinal\intro.wav";
            s.PlayLooping();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
