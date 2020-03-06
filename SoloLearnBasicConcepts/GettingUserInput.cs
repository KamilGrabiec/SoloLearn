using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnBasicConcepts
{
    class GettingUserInput
    {
        public void YourName()
        {
            string yourName;
            Console.WriteLine("What's your name");

            yourName = Console.ReadLine();

            Console.WriteLine("Hello {0}", yourName);
        }

        // Napisać to w taki sposoób aby: metoda GetName zwracała 
        //imię które może być wykorzystane przez metodę ConvertAgeToIng 
        //W rezultacie aby ostatnia linika w ConvertAgeToIng wygladała jak
        //Consol.WriteLine("{0}, your age is {1}", name, age);
        // Output = Kamil, your age is 28
        /*public string GetName(string Name)
        {
            
            Console.WriteLine("What is your name");
            Name = Console.ReadLine();
          
        }
        */
        public void ConvertAgeToIng()
        {
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is {0}", age);
        }
    }

    
}
