using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class NastedIfStatements
    {
        //Show person maturity
        //Method contain known issue when value is negative returns "Child" - TheIfElseIfStatement file resolves that issue
        public void FindGeneration(int x)
        {
            if (x < 18)
            {
                if(x >= 11)
                {
                    Console.WriteLine("Teenanger");
                }
                else
                {
                    Console.WriteLine("Child");
                }
            }
            else
            {
                if (x >= 65)
                {
                    Console.WriteLine("Pensioner");
                }
                else
                {
                    Console.WriteLine("Adult");
                }
            }

        }
    }
}
