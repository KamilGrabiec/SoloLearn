using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class BasicArrays
    {
        public void FirstArray()
        {
        //Array declaraition type + [] + 'name' = new type+[no of elements]
        int[] myFirstArray = new int[5];
 
 
        //Assigne value to inviduale element of array arrayname[no of element] = value;
        myFirstArray[0] = 5;
        }

        public void PreDefinedArray()
        {
            // Declare Array with name, null value, empty value, name, name
            string[] names = new string[5]{"John", null,"", "Mary", "Jessica"};
         
        }

    }
}
