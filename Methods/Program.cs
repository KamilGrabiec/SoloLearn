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


            /*
            NamedParameters multiple = new NamedParameters();
            //Default values
            Console.WriteLine(multiple.VolumeCalculator());

            //Volume of figure where length = 6 and width
            Console.WriteLine(multiple.VolumeCalculator(w:4, l:6));
            */

            /*
            PassingArguments passingArguments = new PassingArguments();

            //Passing argument by value
            int a = 3;
            passingArguments.ByValue(a);
            Console.WriteLine(a);
            */

            //Passing argument as reference
            /*
             * Pass by reference copies an argument's memory address into the formal parameter. Inside the method, the address is used to access the actual argument used in the call. This means that changes made to the parameter affect the argument.
              * To pass the value by reference, the ref keyword is used in both the call and the method definition:
             */


            /*
           int b = 3;
           //The ref keyword is used both when defining the method and when calling it.
           passingArguments.ByReference(ref b);
           Console.WriteLine(b);

           int c;
           passingArguments.ByOutput(out c);
           Console.WriteLine(c);
           */


            /*
            TemperatureCalculator temperatureCalculator = new TemperatureCalculator();
            temperatureCalculator.CalculateTemperature();
            */

            Recusition recusition = new Recusition();
            Console.WriteLine(recusition.FacrorialLoop(5));
            Console.WriteLine(recusition.FactorialRecusitoon(5));



            Console.ReadKey();
        }
    }
}
