using QuizNamePlaceholder.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static QuizNamePlaceholder.utils.QuestEngine;

namespace QuizNamePlaceholder.Screens
{
    public partial class TitleScreen : Form
    {
        private const string questionFilePath = QuestEngine.DEFAULT_PATH;

        private QuestEngine questEngine;
        public TitleScreen()
        {
            InitializeComponent();
            //creates a new QuestEngine using a random seed and the question file path
            questEngine = new QuestEngine(new Random().Next(), questionFilePath);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            //sets testLabel.text to the question text of the next question
            if (questEngine.HasNextQuestion())
            {
                testLabel.Text = questEngine.NextQuestion().Title;
            } else
            {
                testLabel.Text = "No hay más preguntas";
            }
        }
    }
}
