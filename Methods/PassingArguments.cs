using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class PassingArguments
    {

        public void ByValue(int x)
        {
            x *= x;  
        }

        public void ByReference(ref int x)
        {
            x *= x;
        }

        public void ByOutput(out int x)
        {
            x = 123;
        }




    }
}
