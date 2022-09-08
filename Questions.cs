using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizQuestions
{
    public abstract class Questions
    {
        public string Query { get; set; } = String.Empty;
        public string Choices { get; set; }
        public int Answer { get; set; }

        public Questions(string query, string choices, int answer)
        {
            Query = query;
            Choices = choices;
            Answer = answer;
        }

        public void printQuestion()
        {
            Console.WriteLine($"{Query}\n{Choices}");
        }
    }
}
