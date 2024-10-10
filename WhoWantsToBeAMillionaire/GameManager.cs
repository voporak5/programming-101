using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoWantsToBeAMillionaire
{
    internal class GameManager
    {
        //Question[] questions = new Question[15];
        List<Question> questions = new List<Question>();

        int[] pointValues = new int[15]
        {
            100, 200, 300, 500, 1000, 2000, 4000,
            8000,16000,32000,64000,125000,250000,
            500000,1000000
        };


        public GameManager()
        {
            Question question1 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answer = "24oz",
                decoys = ["2oz", "4oz", "6oz", "8oz", "16oz", "32oz"],
                answerIndex = 2
            };
            /*Question question2 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question3 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question4 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question5 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question6 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question7 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question8 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question9 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question10 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question11 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question12 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question13 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question14 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };
            Question question15 = new Question()
            {
                question = "How many oz are in a 24oz cup?",
                answers = ["2oz", "4oz", "24oz", "32oz"],
                answerIndex = 2
            };

            /*questions[0] = question1;
            questions[1] = question2;
            questions[2] = question3;
            questions[3] = question4;
            questions[4] = question5;
            questions[5] = question6;
            questions[6] = question7;
            questions[7] = question8;
            questions[8] = question9;
            questions[9] = question10;
            questions[10] = question11;
            questions[11] = question12;
            questions[12] = question13;
            questions[13] = question14;
            questions[14] = question15;*/

            questions.Add(question1);
            questions.Add(question1);
            questions.Add(question1);
            questions.Add(question1);
            questions.Add(question1);
            questions.Add(question1);

        }

        public void Start()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                Question q = questions[i];

                q.Show();

                //ConsoleKeyInfo keyinfo = Console.ReadKey();
                var keyinfo = Console.ReadKey();

                int choice = 0;
                //bool didEnterValidNumber = int.TryParse(keyinfo.KeyChar.ToString(),out choice);
                if(int.TryParse(keyinfo.KeyChar.ToString(), out choice))
                {
                    //Check to see if user entered a number that is not
                    //a valid answer option
                    if(choice < 1 || choice > 4)
                    {
                        i--;
                    }
                    else
                    {

                        

                        int fixedChoice = choice - 1;


                        if (q.CheckAnswer(fixedChoice))
                        {
                            //They answered the question correctly, let's move on
                        }
                        else if(fixedChoice == 42)
                        {
                            //print out you know everything
                        }
                        
                        else
                        {
                            Gameover();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid input.");
                    //i--;
                    i = i - 1;
                }

            }
        }

        public void ShuffleQuestions()
        {
            
        }


        public void Gameover()
        {
            Console.WriteLine("You lose! Try again? 1)Yes 2)No");
            var keyinfo = Console.ReadKey();

            

            if (keyinfo.KeyChar == '1') Start();
            else Environment.Exit(0);
        }
    }
}
