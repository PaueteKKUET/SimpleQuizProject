using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuizNamePlaceholder.utils
{
    class QuestEngine
    {
        public const string DEFAULT_PATH = "./Data/questions.json"; 

        int Seed { get; }
        private Random Generator;
        private List<Question> Questions;
        private int Index;

        // creates the object with a seed
        public QuestEngine(int seed, string filepath)
        {
            Seed = seed;
            Generator = new Random(Seed);
            Questions = new List<Question>();
            Index = 0;
            
            ImportQuestions(filepath);
        }

        // imports the questions from a json file and adds them to the list
        private void ImportQuestions(string filePath)
        {
            try
            {
                using StreamReader r = new StreamReader(filePath, Encoding.UTF8);
                string json = r.ReadToEnd();
                Questions = JsonConvert.DeserializeObject<List<Question>>(json);
                ShuffleQuestions();
            }
            catch (Exception e)
            {
                // shows a window form alert with the error message
                MessageBox.Show("Error: " + e.Message);

                return;
            }
            
        }

        // shuffles the questions using the seed
        private void ShuffleQuestions()
        {
            Questions = Questions.OrderBy(x => Generator.Next()).ToList();
        }

        //returns the next question in the list
        public Question NextQuestion()
        {
            if (this.HasNextQuestion())
            {
                return Questions[Index++];
            }
            else
            {
                return null;
            }
        }

        //returns if there are more questions
        public bool HasNextQuestion()
        {
            return Index < Questions.Count;
        }

    }

    public class Question
    {
        public const char CORRECT_ANSWER_CHAR = '@';
        public const int MAX_ANSWERS = 4;

        public string Title { get; }
        public string[] Answers;

        public Question(string title, string[] answers)
        {
            Title = title;
            Answers = answers;

            //If title is void or null, throw exception
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Title cannot be null or empty");
            }

            //if answers count is not between 2 and MAX_CORRECT_ANSWERS, throw an exception
            if (Answers.Length < 2 || Answers.Length > MAX_ANSWERS)
            {
                throw new ArgumentException("Answers count must be between 2 and " + MAX_ANSWERS);
            }

        }


        //Returns true if the provided string matches any of the strings in Answers and starts with CORRECT_ANSWER_CHAR
        public bool IsCorrectAnswer(string answer)
        {
            foreach (string a in Answers)
            {
                if (a.StartsWith(CORRECT_ANSWER_CHAR) && a.Substring(1) == answer)
                {
                    return true;
                }
            }
            return false;
        }

        //Returns the Answers array, removing CORRECT_ANSWER_CHAR from the beginning of each string, if present.
        public string[] GetAnswers()
        {
            for (int i = 0; i < Answers.Length; i++)
            {
                if (Answers[i].StartsWith(CORRECT_ANSWER_CHAR))
                {
                    Answers[i] = Answers[i].Substring(1);
                }
            }
            return Answers;
        }
        
    
    }


}
