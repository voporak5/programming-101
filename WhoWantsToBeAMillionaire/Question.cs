using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionaire
{
    internal class Question
    {
        public string question     = String.Empty;
        public string answer       = String.Empty;
        public string[] decoys     = new string[0];
        public int answerIndex;

        public void Show()
        {
            Console.WriteLine(question);

            //Option A
            /*Console.WriteLine("1) " + answers[0]);
            Console.WriteLine("2) " + answers[1]);
            Console.WriteLine("3) " + answers[2]);
            Console.WriteLine("4) " + answers[3]);*/

            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine($"{i+1}) {answers[i]}");
            }

            Console.WriteLine("\nEnter the number of the answer you want to choose");
        }

        public bool CheckAnswer(int n)
        {
            return n == answerIndex;
        }
    }
}
