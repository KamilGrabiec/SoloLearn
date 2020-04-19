using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Recusition
    {
        
        public int FactorialRecusiton(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * FactorialRecusiton(num - 1);
        }
        

        public int FacrorialLoop(int num)
        {
            int result = 1;
            for (int i = num; i > 0; i-- )
            {
                result = result * i;
            }
            return result;
        }
    }
}
