﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsAndLoops
{
    class TheSwitch
    {
        public string TheSwitch2(int num)
        {

            switch (num)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3: case 4:
                    return "three or four";
                default: return "out of range";
            }
        }
    }
}
