using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class TheElseClause
    {
        // Compare to variables and execute statement under condition or else
        public void CompareN1toN2(int x, int y)
        {
            if (x < y)
            {
                Console.WriteLine("y is greater than x - if executed");
            }
            else
            {
                Console.WriteLine("x is not greater than y - else executed");
            }
        }
    }
}
