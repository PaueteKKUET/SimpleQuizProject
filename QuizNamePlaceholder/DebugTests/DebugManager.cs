using QuizNamePlaceholder.Generators.QuestionGenerator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QuizNamePlaceholder.DebugTests
{
    internal class DebugManager
    {

        public const bool DEBUG_MODE = true;

        public static void RunTests()
        {

            Application.Run(new VisualQuestionGenerator());
            //Iniciar aquí los tests que queramos hacer. Recuerda poner DEBUG_MODE a true para que se ejecuten.
        }
    }
}
