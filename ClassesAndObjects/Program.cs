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
            /*
            ATM gosiaAccount = new ATM();
            gosiaAccount.currency = "USD";
            gosiaAccount.NextAction();
            */

            Person p = new Person("Gosia");
            Console.WriteLine(p.GetName());

            WHCharacterCreator gosia = new WHCharacterCreator("krasnolud");
            gosia.GetStats(out int returnHp, out int returMn, out int returnLvl, out string returnRace);
            Console.WriteLine(Convert.ToString(returnHp) + " " + Convert.ToString(returMn) + " " + Convert.ToString(returnLvl) + " " + returnRace);
            Console.ReadKey();

  
        }
    }
}
