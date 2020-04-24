using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Person
    {
        private int age;
        private string name;
        public Person(string nm)
        {
            Console.WriteLine("Hi there");
            name = nm;
        }

        public string GetName()
        {
            return name;
        }
    }
}
