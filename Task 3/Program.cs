using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Task_3
{
    class Program

    {
        private static List<string> lines = new List<string>();
        public int n { get; set; }
        public int c { get; set; }
        public int d { get; set; }

        private static int number;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            printQuestion();


        }
        public static void printQuestion()
        {
            int choice;
            do
            {
                Console.WriteLine("Enter the question number");
                Console.WriteLine("1.Question 1");
                Console.WriteLine("2.Question 2");
                Console.WriteLine("3.Question 3");
                Console.WriteLine("4.Question 4");
                Console.WriteLine("5.Question 5");
                Console.WriteLine("6.Question 6");
                Console.WriteLine("7.Question 7");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Question1();
                        break;
                    case 2:
                        Question2();
                        break;
                    case 3:
                        Question3();
                        break;
                    case 4:
                        Question4();
                        break;
                    case 5:
                        Question5();
                        break;
                    case 6:
                        CowAndBull.Question6();
                        break;
                    case 7:
                        new Program().Question7();
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                } } while (choice != 8);

        }

        public static void Question1()
        {
            List<int> num = new List<int>();
            Console.WriteLine("Enter the 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                num.Add(a);
            }
            Console.WriteLine("The numbers Divisible by 7 are");
            foreach (int item in num)
            {
                if (item % 7 == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }
        public static void Question2()
        {
            int min, max, flag;
            Console.WriteLine("Enter the min and max no:");
            min = Convert.ToInt32(Console.ReadLine());
            max = Convert.ToInt32(Console.ReadLine());
            if (max > min)
            {
                for (int i = min; i <= max; i++)
                {
                    if (i == 1 || i == 0)
                        continue;
                    flag = 1;

                    for (int j = 2; j <= i / 2; ++j)
                    {
                        if (i % j == 0)
                        {
                            flag = 0;
                            break;
                        }
                    }
                    if (flag == 1)
                        Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

        }

        public static void Question3()
        {
            List<int> num = new List<int>();
            Console.WriteLine("Enter number");
            for (int i = 0; i < 100; i++)
            {
                //Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    Console.WriteLine("Number cannot be negative");
                    break;
                }
                else
                {
                    num.Add(number);
                }
            }
            IEnumerable<int> duplicates = num.GroupBy(x => x)
                                        .Where(g => g.Count() > 1)
                                        .Select(x => x.Key);

            Console.WriteLine("Duplicate elements are: " + String.Join(",", duplicates));

        }
        public static void Question4()
        {
            List<int> num = new List<int>();
            Console.WriteLine("Enter number");
            for (int i = 0; i < 100; i++)
            {
                //Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {

                    break;
                }
                else
                {
                    num.Add(number);
                }
            }
            num.Sort();
            Console.WriteLine("The sorted numbers are...");
            foreach (int item in num)
            {
                Console.WriteLine(item);
            }
        }
        public static void Question5()
        {
            string username, password;
            int ctr = 0;
            Console.Write("\nEnter username and password :\n");

            do
            {
                Console.Write("Username:");
                username = Console.ReadLine();

                Console.Write("password:");
                password = Console.ReadLine();

                if (username != "Admin" || password != "admin")
                {
                    ctr++;
                    Console.WriteLine("Invalid Username and Password. Try Again");
                }
                else
                {
                    Console.WriteLine("Welcome!!!!");
                    ctr = 1;
                    break;
                }

            }
            while (ctr < 3);
            if (ctr == 3)
                Console.Write("\nSorry you have already tried 3 times. Try later!!!\n\n");

        }
       

     
        public void Question7()
        {
                int[] CardNum = new int[16];
                int[] CvvNum = new int[3];
                Console.WriteLine("please enter the card number");
                for (int i = 0; i < CardNum.Length; i++)
                {
                    CardNum[i] = Convert.ToInt32(Console.ReadLine());
                }
                //Console.WriteLine("please enter the cvv number by digits ");
                //for (int i = 0; i < CvvNum.Length; i++)
                //{
                //    CvvNum[i] = Convert.ToInt32(Console.ReadLine());
                //}
                //Console.WriteLine("please enter the expiry date");
                //int expiryDate = Convert.ToInt32(Console.ReadLine());
                //if (expiryDate < 01052021)
                //    Console.WriteLine("invalid expirydate");
                //else
                //    Console.WriteLine("valid expirydate");
                int[] REVCardNum = new int[16];
                for (c = REVCardNum.Length - 1, d = 0; c >= 0; c--, d++)
                {
                    REVCardNum[d] = CardNum[c];
                }
                Console.WriteLine("the reversed card number is :");
                for (int i = 0; i < REVCardNum.Length; i++)
                {
                    Console.WriteLine(REVCardNum[i]);
                }
                Console.WriteLine("changing the even position");
                for (int i = 0; i < REVCardNum.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        REVCardNum[i + 1] = REVCardNum[i + 1] * 2;
                    }
                    Console.WriteLine(REVCardNum[i]);
                }
                Console.WriteLine("changing the even position sum into a single digit");
                for (int i = 0; i < REVCardNum.Length; i++)
                {
                    int sum = 0;
                    if (i % 2 == 0)
                    {
                        if (REVCardNum[i + 1] > 10)
                        {
                            while (REVCardNum[i + 1] > 0)
                            {
                                n = REVCardNum[i + 1] % 10;
                                sum = sum + n;
                                REVCardNum[i + 1] = (REVCardNum[i + 1] / 10);
                            }
                            REVCardNum[i + 1] = sum;
                        }
                    }
                    Console.WriteLine(REVCardNum[i]);
                }
    Console.WriteLine(" calculating the total sum of the card number.....");
                int sum1 = 0;
                for (int i = 0; i < REVCardNum.Length; i++)
                {
                    sum1 = REVCardNum[i] + sum1;
                }
                Console.WriteLine("the total sum is " + sum1);
                if (sum1 % 10 == 0)
                    Console.WriteLine("the given card number is valid");
                else
                    Console.WriteLine("the card number is not valid");
            }           
        }
    }


