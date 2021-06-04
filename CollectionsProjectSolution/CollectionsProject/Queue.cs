using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsProject
{
    class Queue
    {
        Queue<string> myQueue;
        public Queue()
        {
            myQueue = new Queue<string>();
        }
        void AddToQueue()
        {
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("This");
            myQueue.Enqueue("is");
            myQueue.Enqueue("Hello");

        }

        void PrintQueue()
        {
            while(myQueue.Count>0)
            {
                Console.WriteLine(myQueue.Dequeue()); 
            }
        }
        //static void Main(string[] a)
        //{
        //    Queue queue = new Queue(); 
        //    queue.AddToQueue();
        //    queue.PrintQueue();
        //    Console.ReadKey();
        //}

    }
}
