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

        Form parent;

        public PantallaFinal(Form parent, int aciertos, int fallos)
        {
            this.parent = parent;

            s.SoundLocation = @"Data\MusicaFinal\intro.wav";
            s.PlayLooping();
            InitializeComponent();


            this.nAciertos.Text = Convert.ToString(aciertos);
            this.nErrores.Text = Convert.ToString(fallos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cerrando...");
            Application.Exit();
        }

        private void TitleScreen_OnFormClosed(object sender, EventArgs e)
        {
            parent.Close();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TitleScreen juego = new TitleScreen(this);
            juego.Show();
        }
    }
}
