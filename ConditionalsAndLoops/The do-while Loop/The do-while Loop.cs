using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class The_do_while_Loop
    {
        /// A do-while is similar to a while loop, except that a do-while
        /// loog is quaranteed to execute at least one time
        public void TheDoWhile(int increment)
        {
            
            do
            {
                Console.WriteLine("This is {0} time of execution", increment+1);
                increment++;

            }
            while (increment < 5);
      
            
        }
    }
}
