using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class While
    {
        //Method display increment value in loop, loop depends of state value
        public void TheWhileLoop(int increment, int state)
        {
            while (increment < 6)
            {
                Console.WriteLine(increment);
                switch (state)
                {
                    case 1:
                        increment++;
                        break;
                    case 2:
                        increment += 2;
                        break;
                    default:
                        increment++;
                        break;

                }
                

                
                increment++;
            }

        }
    }
}
