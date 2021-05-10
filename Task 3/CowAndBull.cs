using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class CowAndBull    
    {              

        private static List<string> lines = new List<string>();
        private static bool amp;

        private static string GetWordFromFile(string path)
            {
                System.IO.StreamReader file =
                new System.IO.StreamReader(@path);

                string line;

                while ((line = file.ReadLine()) != null)
                {
                    lines.Add(line);
                }

                int count = lines.Count;

                Random r = new Random();

                int index = r.Next(count);

                string line1 = lines[index];

                file.Close();

                return line1;
            }

            public static void Question6()
            {              
                char cont = '\0';
                Console.WriteLine("WELCOME TO COWS AND BULLS!\n");
                do
                {
                string w = GetWordFromFile(@"D:\Training\link.txt");
                char[] guessChars = w.ToCharArray();
                char giveUp = '\0';              
                for (int i = 0; i < w.Length; i++)
                    {
                        Console.Write("* ");
                    }
                Console.WriteLine("\n");
                do
                    {
                        Console.Write("Guess the word: ");
                        string guess = Console.ReadLine();
                        if (guess == w)
                        {
                            Console.WriteLine("YOU WIN!\n");
                            break;
                        }
                        else
                        {
                            if (guess.Length == w.Length)
                            {
                                int cows = 0, bulls = 0;
                                for (int i = 0; i < w.Length; i++)
                                {
                                    if (w.Substring(i, 1) == guess.Substring(i, 1))
                                    {
                                        bulls++;
                                        Console.Write("bull ");
                                    }
                                    else
                                    {
                                        cows++;
                                        Console.Write("cow ");
                                    }
                                }
                                Console.WriteLine();
                                Console.WriteLine(bulls + " bulls, " + cows + " cows.\n");
                            }
                            else
                            {
                                Console.WriteLine("LENGTH MISMATCH!");
                            }
                            Console.WriteLine("Do you give up? (y/n): ");
                            string s = Console.ReadLine();
                            while (s.Length == 0)
                            {
                                Console.WriteLine("Do you give up? (y/n): ");
                                s = Console.ReadLine();
                            }
                            giveUp = Convert.ToChar(s.Substring(0, 1));                          //
                                                                       }
                    }
                    while (giveUp != 'y' && giveUp != 'Y');
                    if (giveUp == 'y' || giveUp == 'Y')
                    {
                        Console.WriteLine("The word was: " + w);
                    }
                    Console.WriteLine("Continue? (y/n): ");
                    string s1 = Console.ReadLine();
                    while (s1.Length == 0)
                    {
                        Console.WriteLine("Continue? (y/n): ");
                        s1 = Console.ReadLine();
                    }                  
                    cont = Convert.ToChar(s1.Substring(0, 1));
                } while (cont == 'y' || cont == 'Y');
                Console.WriteLine("Press any key to exit...");
                Console.Read();
        }
        }
    }

