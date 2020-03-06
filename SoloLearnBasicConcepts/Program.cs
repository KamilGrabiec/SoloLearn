using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnBasicConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintingText p = new PrintingText();
            p.HelloWorld();
            p.PrintInt();
            p.PrintDouble();

            GettingUserInput g = new GettingUserInput();
            g.YourName();
            g.ConvertAgeToIng();

        }
    }
}
