using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Computers : Calculator   //DERIVED CLASS
    {

        public Computers()
        {
            Make = "IBM";
            Speed = 100001;
        }

        public override void DoWork() //DYNAMIC POLYMORPHISM -OVERRIDING
        {
            Console.WriteLine("Calculating.....");  //or
           //  base.DoWork();
            Console.WriteLine("Does Work");
        }
    }
    class Calculator //BASE CLASS
    { 
        public string Make { get; set; }
        public int Speed { get; set; }
        public Calculator()
        {
            Make = "ABC Corp.";
            Speed = 101;

        }
        public void calculate()
        {
            Console.WriteLine("Calculating.....");
        }

        public virtual  void DoWork()
        {
            Console.WriteLine("Calculating.....");
        }
        public void PrintCalculatorInfo()
        {
            Console.WriteLine("Make "+Make);
            Console.WriteLine("Speed" +Speed);
        }

    }
}
