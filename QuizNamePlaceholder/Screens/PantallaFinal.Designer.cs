
namespace QuizNamePlaceholder.Screens
{
    partial class PantallaFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.playAgainButton = new System.Windows.Forms.Button();
            this.lbl_errores = new System.Windows.Forms.Label();
            this.lbl_aciertos = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.nAciertos = new System.Windows.Forms.Label();
            this.nErrores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nErrores);
            this.panel1.Controls.Add(this.nAciertos);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.playAgainButton);
            this.panel1.Controls.Add(this.lbl_errores);
            this.panel1.Controls.Add(this.lbl_aciertos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 366);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(216, 309);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(133, 44);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Salir del juego";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.playAgainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playAgainButton.Location = new System.Drawing.Point(216, 247);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(133, 46);
            this.playAgainButton.TabIndex = 5;
            this.playAgainButton.Text = "Jugar otra vez";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.playAgainButton_Click);
            // 
            // lbl_errores
            // 
            this.lbl_errores.AutoSize = true;
            this.lbl_errores.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errores.Location = new System.Drawing.Point(175, 205);
            this.lbl_errores.Name = "lbl_errores";
            this.lbl_errores.Size = new System.Drawing.Size(82, 24);
            this.lbl_errores.TabIndex = 2;
            this.lbl_errores.Text = "Errores: ";
            // 
            // lbl_aciertos
            // 
            this.lbl_aciertos.AutoSize = true;
            this.lbl_aciertos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aciertos.Location = new System.Drawing.Point(175, 164);
            this.lbl_aciertos.Name = "lbl_aciertos";
            this.lbl_aciertos.Size = new System.Drawing.Size(88, 24);
            this.lbl_aciertos.TabIndex = 1;
            this.lbl_aciertos.Text = "Aciertos: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(120)))));
            this.panel2.Controls.Add(this.lbl_resultados);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 93);
            this.panel2.TabIndex = 0;
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.AutoSize = true;
            this.lbl_resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_resultados.Location = new System.Drawing.Point(188, 35);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(185, 29);
            this.lbl_resultados.TabIndex = 0;
            this.lbl_resultados.Text = "RESULTADOS";
            // 
            // nAciertos
            // 
            this.nAciertos.AutoSize = true;
            this.nAciertos.Location = new System.Drawing.Point(285, 171);
            this.nAciertos.Name = "nAciertos";
            this.nAciertos.Size = new System.Drawing.Size(32, 15);
            this.nAciertos.TabIndex = 7;
            this.nAciertos.Text = "UwU";
            // 
            // nErrores
            // 
            this.nErrores.AutoSize = true;
            this.nErrores.Location = new System.Drawing.Point(285, 212);
            this.nErrores.Name = "nErrores";
            this.nErrores.Size = new System.Drawing.Size(46, 15);
            this.nErrores.TabIndex = 8;
            this.nErrores.Text = "UwUn\'t";
            // 
            // PantallaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(636, 394);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaFinal";
            this.Text = "PantallaFinal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TitleScreen_OnFormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button playAgainButton;
        private System.Windows.Forms.Label lbl_errores;
        private System.Windows.Forms.Label lbl_aciertos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.Label nErrores;
        private System.Windows.Forms.Label nAciertos;
    }
}