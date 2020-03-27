using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class TheBreakContinue
    {
        public void TheBreak()
        {
            //Loop with x variable will continue after break
            for (int x = 1; x < 5; x++)
            {
                for(int y = 1; y < 2; y++)
                {
                    if (x > 2)
                    {
                        if (x > 3)
                        {
                            Console.WriteLine("third if");
                            //Break went out from innermost loop, not both of them
                            break;

                        }
                        Console.WriteLine("second if");
                    }
                    
                }
                Console.WriteLine("{0}", x);
            }
        }

        public void TheContinue()
        {
            for(int x = 0; x < 31; x++)
            {
                //Loop will skipp all odd numbers
                if(x%2 == 0)
                {
                    continue;
                }
                Console.WriteLine("{0}", x);
            }
        }
    }
}
