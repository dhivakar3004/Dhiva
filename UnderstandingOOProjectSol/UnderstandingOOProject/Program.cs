using System;

namespace UnderstandingOOProject
{
    class Program
    {
       static void Main(string[] args)
        {
            //Phone phone = new Phone();
            //phone.checkWorkInternal();
            //phone.checkWorkPublic();
            //phone.checkworkPrivate();
            //phone.checkWorkProtected();
            //Calculator calculator = new Calculator();
            //calculator.Make = "XYZ Corp";
            //calculator.PrintCalculatorInfo();
            //calculator.calculate();
            //Computers computer = new Computers();
            //computer.PrintCalculatorInfo();
            //computer.calculate();
            //computer.Dowork();

            //Calculator calculator1, calculator2;
            //calculator1 = new Calculator();
            //calculator2 = new Calculator();
            //calculator1.Make = "AAA Corp";
            //calculator2.Make = "BBB Corp";
            //calculator1.PrintCalculatorInfo();
            //calculator2.PrintCalculatorInfo();

            Calculator calculator = new Calculator();
            calculator.PrintCalculatorInfo();
            calculator.DoWork();
            Console.ReadKey();


            


            Console.ReadKey();
 
         }
    }
}
