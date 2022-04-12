﻿using System;
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

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lbl_usuario.Text))
            {
                MessageBox.Show("Alerta", "Debes introducir un nombre de usuario para jugar");
            }
            else {
                PantallaCarga pc = new PantallaCarga();
                this.Hide();
                pc.Show();
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }
    }
}
