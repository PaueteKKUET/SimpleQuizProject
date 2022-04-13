
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ans4 = new System.Windows.Forms.Button();
            this.ans3 = new System.Windows.Forms.Button();
            this.ans2 = new System.Windows.Forms.Button();
            this.ans1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.questionLabel.AutoEllipsis = true;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(3, 26);
            this.questionLabel.MaximumSize = new System.Drawing.Size(320, 45);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(32, 15);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "UwU";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(405, 3);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(46, 24);
            this.testButton.TabIndex = 2;
            this.testButton.Text = "Next";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(460, 237);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.questionLabel);
            this.panel1.Controls.Add(this.testButton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 61);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ans4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ans3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ans2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ans1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 160);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ans4
            // 
            this.ans4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ans4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(178)))));
            this.ans4.Location = new System.Drawing.Point(230, 83);
            this.ans4.Name = "ans4";
            this.ans4.Size = new System.Drawing.Size(221, 74);
            this.ans4.TabIndex = 3;
            this.ans4.Text = "D";
            this.ans4.UseVisualStyleBackColor = false;
            this.ans4.Click += new System.EventHandler(this.ans4_Click);
            // 
            // ans3
            // 
            this.ans3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ans3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(178)))));
            this.ans3.Location = new System.Drawing.Point(3, 83);
            this.ans3.Name = "ans3";
            this.ans3.Size = new System.Drawing.Size(221, 74);
            this.ans3.TabIndex = 2;
            this.ans3.Text = "C";
            this.ans3.UseVisualStyleBackColor = false;
            this.ans3.Click += new System.EventHandler(this.ans3_Click);
            // 
            // ans2
            // 
            this.ans2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ans2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(178)))));
            this.ans2.Location = new System.Drawing.Point(230, 3);
            this.ans2.Name = "ans2";
            this.ans2.Size = new System.Drawing.Size(221, 74);
            this.ans2.TabIndex = 1;
            this.ans2.Text = "B";
            this.ans2.UseVisualStyleBackColor = false;
            this.ans2.Click += new System.EventHandler(this.ans2_Click);
            // 
            // ans1
            // 
            this.ans1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ans1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(178)))));
            this.ans1.Location = new System.Drawing.Point(3, 3);
            this.ans1.Name = "ans1";
            this.ans1.Size = new System.Drawing.Size(221, 74);
            this.ans1.TabIndex = 0;
            this.ans1.Text = "A";
            this.ans1.UseVisualStyleBackColor = false;
            this.ans1.Click += new System.EventHandler(this.ans1_Click);
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(243)))), ((int)(((byte)(178)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TitleScreen";
            this.Text = "Menú principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TitleScreen_OnFormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ans1;
        private System.Windows.Forms.Button ans2;
        private System.Windows.Forms.Button ans3;
        private System.Windows.Forms.Button ans4;
    }
}