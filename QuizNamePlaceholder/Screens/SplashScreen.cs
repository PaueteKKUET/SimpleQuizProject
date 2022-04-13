using System;
using System.Windows.Forms;

namespace QuizNamePlaceholder.Screens
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InicioSesion ins = new InicioSesion(this);
            this.Hide();
            ins.Show();
            timer1.Enabled = false;
        }
    }
}
