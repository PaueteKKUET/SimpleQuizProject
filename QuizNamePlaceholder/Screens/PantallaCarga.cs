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
        Form parent;
        
        public PantallaCarga(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment((int) new Random().Next(1, 5));
            label1.Text = progressBar1.Value.ToString() + "%";

              if (progressBar1.Value == progressBar1.Maximum)
              {
                  timer1.Stop();
                  this.Hide();
                  TitleScreen ts = new TitleScreen(this);
                  ts.ShowDialog();
              }
        }

        private void TitleScreen_OnFormClosed(object sender, EventArgs e)
        {
            parent.Close();
        }
    }
}
