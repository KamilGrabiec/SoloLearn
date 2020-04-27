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

            /*
            Person p = new Person("Gosia");
            Console.WriteLine(p.GetName());
            */

            /* 
            WHCharacterCreator gosia = new WHCharacterCreator("krasnolud");
            gosia.GetStats(out int returnHp, out int returMn, out int returnLvl, out string returnRace);
            Console.WriteLine(Convert.ToString(returnHp) + " " + Convert.ToString(returMn) + " " + Convert.ToString(returnLvl) + " " + returnRace);
            
            */

            Properties_Pet dog1 = new Properties_Pet("Dog", "Golden Retriver");
            dog1.Name = "Blant";
            dog1.Age = 1;

            Console.WriteLine("{0}{1}{2}{3}", dog1.Species, dog1.Race, dog1.Name, dog1.Age);






            Console.ReadKey();

        }
    }
}
