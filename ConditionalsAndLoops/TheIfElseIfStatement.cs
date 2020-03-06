using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class TheIfElseIfStatement
    {
        public void FindGeneration2(int age)
        {
            if (age > 0)
            {
                if ( age < 18)
                {
                    if (age >= 11)
                    {
                        Console.WriteLine("Teenanger");
                    }
                    else
                    {
                        Console.WriteLine("Child");
                    }
                }
                else if (age >= 65)
                {
                    Console.WriteLine("Pensioner");
                }
                else
                {
                    Console.WriteLine("Adult");
                }
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
