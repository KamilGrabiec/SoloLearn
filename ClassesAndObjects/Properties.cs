using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Properties_Pet
    {
            private string species;
            private string race;
            //field name was created as auto-property
            //private string name;
            private int age;
            
            public Properties_Pet(string sp, string rc)
            {
                species = sp;
                race = rc;
            }

            public string Species
            {
                get { return species; }
            }

            public string Race
            {
                get { return race; }
            }

            //auto-implemented property. There is no need to declare name variable
            public string Name { get; set; }
            /*public string Name
            {
                get { return name; }
                set { name = value; }
            }
            */

            public int Age
            {
                get { return age; }
                set
                {
                if(value>0)
                    age = value;
                }
            }
        
    }
}
