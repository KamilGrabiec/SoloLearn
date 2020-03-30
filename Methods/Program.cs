using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            NameConvention calculator = new NameConvention();
            calculator.SumTwoVariables(5, 8);
            */

            /*
            OptionalArguments divide = new OptionalArguments();
            divide.DivideBy(6);
            divide.DivideBy(6, 3);
            */

            NamedParameters multiple = new NamedParameters();
            //Default values
            Console.WriteLine(multiple.VolumeCalculator());

            //Volume of figure where length = 6 and width
            Console.WriteLine(multiple.VolumeCalculator(w:4, l:6));

            Console.ReadKey();
        }
    }
}
