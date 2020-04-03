using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class MethodOveloading
    {
        public void Print()
        {
            Console.WriteLine("No parameter to print");
        }

        public void Print(int num)
        {
            Console.WriteLine("Intiger to print = {0}", num);
        }

        public void Print(string str)
        {
            Console.WriteLine("String to print is {0}", str);
        }
    }
}
