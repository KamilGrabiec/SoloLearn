using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicArrays p = new BasicArrays();
            p.FirstArray();
            p.PreDefinedArray();

            ArraysAndLoops array = new ArraysAndLoops();
            array.DisplayArray();

            Console.WriteLine(array.SurfaceList());


            Console.ReadKey();
        }
    }
}
