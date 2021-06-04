using System;
using System.Collections.Generic;
using System.Collections;

namespace CollectionsProject
{
    class Program
    {
        //int[] numbers = new int[10];
        //List<int> numbers = new List<int>;
        ArrayList numbers = new ArrayList();

        //n numbers of numbers
        //count is not pre-defined
        /// <summary>
        /// Takes numbers from user until user enters a negative number
        /// </summary>
        List <int> TakeNumbersFromUser()
        {
            List<int> numbers = new List<int>();
            int number = 0;
            do
            {
                Console.WriteLine("Please Enter a Number . Enter negative Number to Exit");
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    int result = 10 / number;
                    if (number >= 0)
                        numbers.Add(number);
                }
                catch (DivideByZeroException dbz)
                {

                    Console.WriteLine("We cannot divide a number by zero");
                    Console.WriteLine(dbz.Message);
                }
                catch (FormatException format)
                {

                    Console.WriteLine("We are expecting a number. please enter a whole number");
                    Console.WriteLine(format.Message);
                }
                catch (OverflowException ofe)
                {

                    Console.WriteLine("The number is too big");
                    Console.WriteLine(ofe.Message);
                }
            } while (number >= 0);
            Console.WriteLine("The number of numbers entered is  "+numbers.Count);
            if (numbers.Count == 0)
                numbers = null;
            return numbers;
        }
        void SortGivenNumbers()
        {
            //Take numer from user
            //Sort the numbers
            //Print the sorted number

            List<int> mynumbers = TakeNumbersFromUser();
            try
            {
                if(mynumbers != null)
                {
                    mynumbers.Sort();
                    printTheCollection(mynumbers);
                }
                else
                {
                    Console.WriteLine("The collection id empty");
                }
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("There are no numbes to be sorted");
            }
         
            
        }    
        private void printTheCollection(List<int> mynumbers)
        {
            foreach(var item in mynumbers)
            {
                Console.WriteLine(item);
            }
        }      
               
         

            


      
        //static void Main(string[] args)
        //{
        //    new Program().SortGivenNumbers();
        //    Console.ReadKey();
        //}
    }
}
