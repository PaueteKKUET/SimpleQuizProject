﻿using QuizNamePlaceholder.utils;
using System;
using System.Windows.Forms;
using System.Media;

namespace QuizNamePlaceholder.Screens
{
    public partial class TitleScreen : Form
    {
        private const string questionFilePath = QuestEngine.DEFAULT_PATH;

        SoundPlayer s = new SoundPlayer();
        Form parent;
        private QuestEngine questEngine;

        private Button[] answerButtons;
        private Question currentQuestion;
        private bool isAnswered = true;

        private int aciertos;
        private int fallos;

        public TitleScreen(Form parent)
        {
            this.parent = parent;
            this.aciertos = 0;
            this.fallos = 0;

            s.SoundLocation = @"Data\MusicaFinal\Juego.wav";
            s.PlayLooping();
            InitializeComponent();
            //creates a new QuestEngine using a random seed and the question file path
            questEngine = new QuestEngine(new Random().Next(), questionFilePath);

            answerButtons = new Button[] { ans1, ans2, ans3, ans4 };

            testButton_Click(null, null);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (!isAnswered)
            {
                Shake();
                return;
            }

            ResetColors();

            this.isAnswered = false;
            
            if (questEngine.HasNextQuestion())
            {
                SetQuestion(questEngine.NextQuestion());
            } else
            {
                this.Hide();
                PantallaFinal score = new PantallaFinal(this, aciertos, fallos);
                score.Show();
            }
        }

        private void SetQuestion(Question question)
        {
            this.currentQuestion = question;
            questionLabel.Text = currentQuestion.Title;
            
            foreach (Button but in answerButtons)
            {
                but.Hide();
            }

            for (int i = 0; i < answerButtons.Length && i < currentQuestion.GetAnswers().Length; i++)
            {
                answerButtons[i].Text = currentQuestion.GetAnswers()[i];
                answerButtons[i].Show();
            }

        }

        private void TitleScreen_OnFormClosed(object sender, EventArgs e)
        {
            parent.Close();
        }

        private void ans1_Click(object sender, EventArgs e)
        {
            DeclareAnswer(0);
        }

        private void ans2_Click(object sender, EventArgs e)
        {
            DeclareAnswer(1);
        }

        private void ans3_Click(object sender, EventArgs e)
        {
            DeclareAnswer(2);
        }

        private void ans4_Click(object sender, EventArgs e)
        {
            DeclareAnswer(3);
        }

        private void DeclareAnswer(int n)
        {
            if (isAnswered)
            {
                return;
            }

            isAnswered = true;

            if (currentQuestion.IsCorrectAnswer(answerButtons[n].Text))
            {
                this.aciertos++;
                answerButtons[n].BackColor = System.Drawing.Color.Green;

                this.BackColor = System.Drawing.Color.Green;
            } else
            {
                this.fallos++;
                answerButtons[n].BackColor = System.Drawing.Color.Red;
                foreach (Button but in answerButtons)
                {
                    if (currentQuestion.IsCorrectAnswer(but.Text)) {
                        but.BackColor = System.Drawing.Color.Green;
                    }
                }

                this.BackColor = System.Drawing.Color.Red;
                Shake();
            }


        }

        private void ResetColors()
        {
            this.BackColor = System.Drawing.Color.FromArgb(250, 243, 178);
            foreach (Button but in answerButtons)
            {
                but.BackColor = System.Drawing.Color.FromArgb(250, 243, 178);
            }
        }

        private void Shake()
        {

            int initialX = this.Location.X;
            int initialY = this.Location.Y;

            // shakes the window
            for (int i = 0; i < 25; i++)
            {
                this.Location = new System.Drawing.Point(initialX + (i % 2 == 0 ? -2 : 2), initialY + (i % 2 == 0 ? -2 : 2));
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}
