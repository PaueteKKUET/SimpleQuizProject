using QuizNamePlaceholder.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuizNamePlaceholder.Generators.QuestionGenerator;
using Newtonsoft.Json;
using System.IO;

namespace QuizNamePlaceholder.Generators.QuestionGenerator
{
    public partial class VisualQuestionGenerator : Form
    {
        List<TextBox> answers;
        List<CheckBox> corrects;
        public VisualQuestionGenerator()
        {
            InitializeComponent();

            answers = new List<TextBox>();
            answers.Add(in_r1);
            answers.Add(in_r2);
            answers.Add(in_r3);
            answers.Add(in_r4);
            answers.Add(in_r5);
            answers.Add(in_r6);

            corrects = new List<CheckBox>();
            corrects.Add(in_correct_r1);
            corrects.Add(in_correct_r2);
            corrects.Add(in_correct_r3);
            corrects.Add(in_correct_r4);
            corrects.Add(in_correct_r5);
            corrects.Add(in_correct_r6);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            bool hasCorrectAnswer = false;
            foreach(CheckBox correct in corrects)
            {
                if (correct.Checked)
                {
                    hasCorrectAnswer = true;
                }
            }

            if (!hasCorrectAnswer)
            {
                MessageBox.Show("Debes marcar, al menos, una respuesta correcta");
                return;
            }

            if (in_pregunta.Text.Length < 1)
            {
                MessageBox.Show("La pregunta está vacía");
            }

            List<String> respuestas = new List<string>();
            int index = 0;

            foreach (TextBox answer in answers)
            {
                if (answer.Text.Length > 0)
                {
                    bool isCorrect = false;
                    int correctIndex = 0;
                    foreach (CheckBox box in corrects)
                    {
                        if (correctIndex == index)
                        {
                            isCorrect = box.Checked;
                        }
                        correctIndex++;
                    }

                    if (isCorrect)
                    {
                        answer.Text = Question.CORRECT_ANSWER_CHAR + answer.Text;
                    }
                    respuestas.Add(answer.Text);
                }
                index++;
            }

            if (respuestas.Count < 2)
            {
                MessageBox.Show("No hay suficientes respuestas");
                return;
            }

            QuestEngine existingEngine = new QuestEngine(0, QuestEngine.DEFAULT_PATH);
            List<Question> questions = new List<Question>();

            while (existingEngine.HasNextQuestion())
            {
                questions.Add(existingEngine.NextQuestion());
            }

            string[] respuestasArray = new string[respuestas.Count];
            index = 0;
            foreach (string respuesta in respuestas)
            {
                respuestasArray[index] = respuesta;
                index++;
            }

            Question preguntaNueva;
            try
            {
                preguntaNueva = new Question(in_pregunta.Text, respuestasArray);
            } catch (ArgumentException)
            {
                MessageBox.Show("Demasaidas respuestas :(");
                return;
            } 
            questions.Add(preguntaNueva);
            string saveObject = JsonConvert.SerializeObject(questions, Formatting.Indented);
            File.WriteAllTextAsync(QuestEngine.DEFAULT_PATH, saveObject);

            MessageBox.Show("Pregunta añadida :D");
            foreach (TextBox text in answers)
            {
                text.Text = "";
            }

            foreach (CheckBox box in corrects)
            {
                box.Checked = false;
            }

            in_pregunta.Text = "";
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
