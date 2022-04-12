using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizNamePlaceholder.Screens
{
    public partial class PantallaCarga : Form
    {
        public PantallaCarga()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
              progressBar1.Increment(1);
              label1.Text = progressBar1.Value.ToString() + "%";

              if (progressBar1.Value == progressBar1.Maximum)
              {
                  timer1.Stop();
                  this.Hide();
                  TitleScreen ts = new TitleScreen();
                  ts.ShowDialog();
              }
        }
    }
}
