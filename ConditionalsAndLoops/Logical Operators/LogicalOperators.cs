using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops.Logical_Operators
{
    class LogicalOperators
    {
        public void TheAnd(int age, string sex, int money)
        {
            if(age>= 18 && sex == "f")
            {
                Console.WriteLine("mature woman");
            }
            if (age >= 18 && sex =="f" && money > 1000)
            {
                Console.WriteLine("And ritch!");
            }
            else
            {
                Console.WriteLine("Not mature woman");
            }
        }

        public void TheOr(int age)
        {
            if(age >0 && (age < 18 || age >= 65))
            {
                Console.WriteLine("Person is not-productive");
            }
            else if(age >= 18)
            {
                Console.WriteLine("Person is productive");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
