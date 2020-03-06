using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class RelationalOperators
    {


        public void GreaterOrEqual(int x,int y)
        {
            if (y >= x)
            {
                Console.WriteLine("y is greater or equal to x");
            }
        }

        public void LessOrEqual(int x, int y)
        {
            if (x <= y)
            {
                Console.WriteLine("x is less or equal to y");
            }
        }

        public void Equal(int x, int xx)
        {
            if (x == xx)
            {
                Console.WriteLine("x is equal to xx");
            }
        }

        public void NotEqual(int x, int y)
        {
            if (x != y)
            {
                Console.WriteLine("x is not equal to y");
            }
        }
    }
}
