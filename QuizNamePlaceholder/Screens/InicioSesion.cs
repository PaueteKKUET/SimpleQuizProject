using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuizNamePlaceholder.Screens
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_usuario))
            {
                MessageBox.Show("Alerta", "Debes introducir un nombre de usuario");
            }
            else {
                PantallaCarga pc = new PantallaCarga();
                this.Hide();
                pc.Show();
            }
        }
    }
}
