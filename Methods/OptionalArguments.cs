using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class OptionalArguments
    {
        public void DivideBy(int x, int y = 2)
        {
            if (y == 2)
            {
                Console.WriteLine("You have divided x by default value = 2");
                Console.WriteLine(x / y);
            }
            else
            {
                Console.WriteLine("You have divided x by optional parameter value = {0}", y);
                Console.WriteLine(x / y);
            }
        }
    }
}
