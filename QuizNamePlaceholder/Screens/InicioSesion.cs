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
    public partial class InicioSesion : Form
    {
        SoundPlayer s = new SoundPlayer();

        Form parent;

        public InicioSesion(Form parent)
        {
            this.parent = parent;
            s.SoundLocation = @"Data\MusicaFinal\intro.wav";
            s.PlayLooping();
            InitializeComponent();
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_usuario.Text))
            {
                MessageBox.Show("Alerta", "Debes introducir un nombre de usuario para jugar");
            }
            else {
                PantallaCarga pc = new PantallaCarga(this);
                s.Stop();
                this.Hide();
                pc.Show();
            }
        }

        private void TitleScreen_OnFormClosed(object sender, EventArgs e)
        {
            parent.Close();
        }
    }
}
