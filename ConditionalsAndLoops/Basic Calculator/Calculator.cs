using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops.Basic_Calculator
{
    class Calculator
    {
        //endless sum 2 readed values, if first value = exit then break
        public void CalculateSum()
        {
            do
            {
                Console.WriteLine("x = ");
                string strx = Console.ReadLine();
                if(strx == "exit")
                {
                    break;
                }
                int x = Convert.ToInt32(strx);
                

                Console.WriteLine("y = ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                Console.WriteLine("Result:{0}", sum);
            }
            while (true);
        }
    }
}
