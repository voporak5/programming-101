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
        public List<string> decoys = new List<string>();
        public List<string> decoysUsed = new List<string>();
        public int answerIndex;

        public void Show()
        {
            //decoysUsed = new bool[decoys.Count];

            Console.WriteLine(question);

            //Option A
            /*Console.WriteLine("1) " + answers[0]);
            Console.WriteLine("2) " + answers[1]);
            Console.WriteLine("3) " + answers[2]);
            Console.WriteLine("4) " + answers[3]);*/

            for (int i = 0; i < 4; i++)
            {
                if (i == answerIndex)
                {
                    Console.WriteLine($"{i + 1}) {answer}");
                }
                else
                {
                    //Console.WriteLine($"{i + 1}) {decoys[Random.Shared.Next(decoys.Length)]}");
                    int decoyIndex = Random.Shared.Next(decoys.Count);

                    //while(decoysUsed[decoyIndex])
                    //{
                    //decoyIndex = Random.Shared.Next(decoys.Length);
                    //}

                    decoysUsed.Add(decoys[decoyIndex]);
                    decoys.RemoveAt(decoyIndex);
                    //decoysUsed[decoyIndex] = true;
                    Console.WriteLine($"{i + 1}) {decoys[decoyIndex]}");
                }
            }

            Console.WriteLine("\nEnter the number of the answer you want to choose");
        }

        public bool CheckAnswer(int n)
        {
            return n == answerIndex;
        }
    }
}
