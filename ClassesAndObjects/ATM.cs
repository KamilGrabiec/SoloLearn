using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class BankAccount
    {
        int balance = 0;

        public void Deposit()
        {
            int deposit;
            Console.WriteLine("How much would you like to deposit?");
            deposit = Convert.ToInt32(Console.ReadLine());
            balance = balance + deposit;
            Continue();
        }

        public void Withdrawal()
        {
            int withdrawal;
            Console.WriteLine("How much would you like to withdraw?");
            withdrawal = Convert.ToInt32(Console.ReadLine());
            balance = balance - withdrawal;
            Continue();
        }

        public void CheckAccountBalance()
        {
            Console.WriteLine("Your account balance is {0}", balance);
            Continue();
        }

        public void Continue()
        {
            Console.WriteLine("Would you like to continue? [Y/N]");
            string @continue = Console.ReadLine();
            if(@continue == "Y" || @continue == "y")
            {
                NextAction();
            }
            else
            {
                Console.WriteLine("Good bye");
            }
        }

        public void NextAction()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Type 1 to check banalce, 2 to deposit, 3 to withdraw");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    CheckAccountBalance();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    Withdrawal();
                    break;

            }

        }
    }
}
