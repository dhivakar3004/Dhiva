using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class UnderstandingStack
    {
        Stack<string> myStack;
        public UnderstandingStack()
        {
            myStack = new Stack<string>();
        }

        void AddItemsToStack()
        {
            myStack.Push("Red");
            myStack.Push("Blue");
            myStack.Push("Yellow");
            myStack.Push("Orange");
           
        }

        //void PrintStack()
        //{
        //    foreach (var item in myStack)
        //    {
        //        Console.WriteLine(item);
        //    }
        
            void PrintStack() 
        { 
            while (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Pop());
            }
            Console.WriteLine(myStack.Count);
        }

         //static void Main(string[] a)
         //   {
         //       UnderstandingStack understandingstack = new UnderstandingStack();
         //       understandingstack.AddItemsToStack();
         //       understandingstack.PrintStack();
         //       Console.ReadKey();
         //   }
        }
    }

