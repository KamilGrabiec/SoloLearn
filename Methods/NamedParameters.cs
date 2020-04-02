using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class NamedParameters
    {
        //Calculator of boject created by squares with side 2
        public int VolumeCalculator( int l = 2, int w =2, int h = 2)
        {

            int volume = (l * w * h);
            return volume; 
        }
    }
}
