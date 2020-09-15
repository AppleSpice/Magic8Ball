using System;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static Random randomObject = new Random();

        static void Main(string[] args)
        {
            QuestionLoop();
        }

        static string GetQuestionFromUser()
        {
            Console.Write("What question do you have?");
            string questionString = Console.ReadLine();
            return questionString;
        }

        static void QuestionLoop()
        {
            while(true)
            {
                int numberOfSecondsToSleep = randomObject.Next((5) + 1);
                Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                string questionString = GetQuestionFromUser();

                if (questionString.ToLower() == "quit")
                {
                    break;
                }

                if (questionString.ToLower() == "bruh")
                {
                    Console.WriteLine("This really is a bruh moment");
                    break;
                }

                Console.WriteLine("Hmmmmm... let me think...");
                Thread.Sleep(numberOfSecondsToSleep * 1000);
                int randomNumber = randomObject.Next(10);
                switch(randomNumber)
                {
                    case 0:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Yes!");
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("No!");
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Bad Idea!");
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("That's a mystery for the ages!");
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Maybe!");
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Perhaps!");
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Absolutly!");
                            break;
                        }
                    case 7:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Absolutly not!");
                            break;
                        }
                    case 8:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Thats not even english!");
                            break;
                        }
                    case 9:
                        {
                            Console.ForegroundColor = (ConsoleColor)randomObject.Next(15);
                            Console.WriteLine("Bruh!");
                            break;
                        }
                }
            }
        }
    }
}
