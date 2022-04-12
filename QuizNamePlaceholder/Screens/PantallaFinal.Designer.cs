
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_aciertos = new System.Windows.Forms.Label();
            this.lbl_errores = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_errores);
            this.panel1.Controls.Add(this.lbl_aciertos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 366);
            this.panel1.TabIndex = 0;
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
            // lbl_aciertos
            // 
            this.lbl_aciertos.AutoSize = true;
            this.lbl_aciertos.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_aciertos.Location = new System.Drawing.Point(175, 164);
            this.lbl_aciertos.Name = "lbl_aciertos";
            this.lbl_aciertos.Size = new System.Drawing.Size(99, 22);
            this.lbl_aciertos.TabIndex = 1;
            this.lbl_aciertos.Text = "Aciertos: ";
            // 
            // lbl_errores
            // 
            this.lbl_errores.AutoSize = true;
            this.lbl_errores.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_errores.Location = new System.Drawing.Point(175, 205);
            this.lbl_errores.Name = "lbl_errores";
            this.lbl_errores.Size = new System.Drawing.Size(89, 22);
            this.lbl_errores.TabIndex = 2;
            this.lbl_errores.Text = "Errores: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 23);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(187)))), ((int)(((byte)(120)))));
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(216, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "Jugar otra vez";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(133)))), ((int)(((byte)(92)))));
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(216, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 44);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir del juego";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.AutoSize = true;
            this.lbl_resultados.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_resultados.Location = new System.Drawing.Point(188, 35);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(180, 27);
            this.lbl_resultados.TabIndex = 0;
            this.lbl_resultados.Text = "RESULTADOS";
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_errores;
        private System.Windows.Forms.Label lbl_aciertos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_resultados;
    }
}