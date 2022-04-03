
namespace QuizNamePlaceholder.Screens
{
    partial class TitleScreen
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
            this.testLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(137, 95);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(32, 15);
            this.testLabel.TabIndex = 1;
            this.testLabel.Text = "UwU";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(125, 235);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(131, 48);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Siguiente pregunta :D";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testLabel);
            this.Name = "TitleScreen";
            this.Text = "Menú principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Button testButton;
    }
}