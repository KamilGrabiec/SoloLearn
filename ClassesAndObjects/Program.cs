using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {

            ATM gosiaAccount = new ATM();
            gosiaAccount.currency = "USD";
            gosiaAccount.NextAction();
  
        }
    }
}
