using System;

namespace UnderstandingDelegate
{
    class Program
    {
        void AddPassByValue(int num1)
        {
            Console.WriteLine("Pass by ref before increment " + num1);
            num1 = num1 + 1;
            Console.WriteLine("Pass by ref after increment " + num1);
        }

      
        void AddPassByRef(ref int num1)
        {
            Console.WriteLine("Pass by val before increment " + num1);
            num1 = num1 + 1;
            Console.WriteLine("Pass by val after increment " + num1);
        }
        void callMethods()
        {
            int num1 = 10;
            Console.WriteLine("Calling method - before passby val call" + num1);
            AddPassByValue(num1);
            Console.WriteLine("Calling method - after passby val call" + num1);

            Console.WriteLine("Calling method - before passby ref call" + num1);
            AddPassByRef(ref num1);
            Console.WriteLine("Calling method - after passby ref call" + num1);

        }

        void WorkWithNothing(SummaClass summa)
        {
            summa.PrintNothing(); 
            Console.WriteLine(summa.Nothing);
            summa.Nothing = 200;
        }

        void CallWork()
        {
            SummaClass summa = new SummaClass();
            summa.Nothing = 100;
            WorkWithNothing(summa);
            Console.WriteLine(summa.Nothing);
        }
        public delegate void myDelegate();

        //void MyMethod()
        //{
        //    Console.WriteLine("This is the method ");
        //}
        //void GetMethodAsParameter(myDelegate del)
        //{
        //    del();
        //}

        //void CallMethodWithMethodParameter()
        //{
        //    myDelegate objDelegate = new myDelegate(MyMethod);
        //    GetMethodAsParameter(objDelegate);
        //}
        void GetMethodAsParameter(Action del)
        {
            del();
        }
        void GetMethodWithParamAsParamerter(Action <int,int> act)
        {
            act(10, 30);
        }
        void GetMethodWithParamAndReturnAsParamerter(Func<int, int> func)
        {
            int valuce = func(10);
            Console.WriteLine(valuce);
        }
        void GetMethodWithParamAndReturnBoolAsParamerter(Predicate<SummaClass>func)
        {
            SummaClass summa = new SummaClass();
            summa.Nothing = 100;
            bool value = func(summa);
            Console.WriteLine("The result "+value);
        }
        void AnonMethodDelegate()
        {
            //myDelegate objDelegate = delegate () { Console.WriteLine("From an anon method"); };//Anon method
            //objDelegate += delegate () { Console.WriteLine("Another anon method"); };//Anon method
            //myDelegate objDelegate = ()=> { Console.WriteLine("From an anon method"); };//Lambda Expression
            //objDelegate += ()=> { Console.WriteLine("Another anon method"); };//Lambda expression
            //GetMethodAsParameter(objDelegate);

            //Action objDelegate = () => { Console.WriteLine("From an build delegate method"); };//Pre build delegate andLambda Expression
            //objDelegate += () => { Console.WriteLine("Another build delegate method"); };//pre build delegate adding one more Lambda expression
            //GetMethodAsParameter(objDelegate);

            //Action <int,int>act=(num1,num2)=>  Console.WriteLine("The product is "+(num1*num2));
            //GetMethodWithParamAsParamerter(act);

            //Func<int, int> myFunc = (num1) => num1 * 100;
            //GetMethodWithParamAndReturnAsParamerter(myFunc);

            Predicate<SummaClass> predicate = s => s.Nothing > 10;
            GetMethodWithParamAndReturnBoolAsParamerter(predicate);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //new Program().callMethods();
            //new Program().CallWork();
           // new Program().CallMethodWithMethodParameter();
            new Program().AnonMethodDelegate();
            Console.ReadLine();
        }
    }
}
