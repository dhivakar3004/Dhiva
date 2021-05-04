using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    public class Bank
    {   
        void UnderstandingOperatoroverloading()
        {
            Accounts account1 = new Accounts("12354", 10000, "aajay");
            Accounts account2 = new Accounts("54678", 670000, "vijay");
            Accounts account3 = account1 + account2;
            account1.PrintAccountDetails();
            account2.PrintAccountDetails();
            account3.PrintAccountDetails();
            Console.WriteLine("printing the reference");
            Console.WriteLine(account3);
    }
        //static void Main (string[] a)
        //{
        //    //Accounts account = new Accounts();
        //    //account.OpenAccount("9898676",6543);
        //    //Accounts account2 = new Accounts("2021294",12344.6,"Dhiva");
        //    //account2.PrintAccountDetails();
            
        //}

        void createAndCheck()
        {
            Accounts account = new Accounts();
            account.OpenAccount("2021245");
            account = null;//Removing reference ot the object
            Console.WriteLine(account.AccountNumber);
        }
    }
}
