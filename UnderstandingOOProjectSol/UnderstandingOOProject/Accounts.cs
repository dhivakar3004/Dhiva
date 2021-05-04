using System;
using System.Collections.Generic;
using System.Text;

namespace UnderstandingOOProject
{
    class Accounts
    {
        public string AccountNumber { get; set; }

        public double Balance{ get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

         public static Accounts operator +(Accounts account1 ,Accounts account2)
        {
            Accounts result = new Accounts();
            result.AccountNumber = account1.AccountNumber +"&" +account2.AccountNumber;
            result.Balance = account1.Balance + account2.Balance;
            result.Name = account1.Name + "&" + account2.Name;
            return result;

        }
        public Accounts()
        {
            AccountNumber = "0000000";
            Balance = 0.0;
            Name = "No one";
            Type = "not yet sure";
        }
        public Accounts(string accountNumber,double  balance ,string name)
        {
            AccountNumber = accountNumber;
            Balance =balance;
            Name = name;
            Type = "not yet sure";
        
            }

        object objl;
        public override string ToString()
        {
            return "Account Number:" + AccountNumber + "\nName of the Account:" + Name +
                "\nBalance :" + Balance;
        }
        public void OpenAccount()
        {
            Console.WriteLine("GO to bank and open an account");

        }
        public void OpenAccount(string PanNumber)
        {
            Console.WriteLine("Use the pannumber {0} and  GO to Online and Open the account", PanNumber);
        }


        public void OpenAccount(string PanNumber, double balance)
            {   Balance = balance;
                Console.WriteLine("Use the pannumber {0} and  GO to Online and Open the account with balance{0}",balance);

            }

        public void OpenAccount(string PanNumber, string aadhar)
            {
                Balance = Balance;
                Console.WriteLine("Use the aadhar number {0} and Open the Acoount in Online with balance{0}",Balance);

            }
        public void PrintAccountDetails()
        {
            Console.WriteLine("Account Number:" + AccountNumber + "\nName of the Account:" + Name + 
                "\nBalance :" + Balance);
        }
        ~Accounts()

            {

            }
        

        }
}
