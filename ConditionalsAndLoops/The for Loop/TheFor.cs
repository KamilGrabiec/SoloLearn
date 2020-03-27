using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class TheFor
    {
        public void TheForLoop(int x)
        {
            /*Typical For 
             * for (init; condition; increment){
             * statement(s);
             * }
             */
            
            for (; x < 15; x++)
            {
                Console.WriteLine("Value of x: {0}", x);
            }

        }
    }
}
