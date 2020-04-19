using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Pyramid
    {
        public void DrawPyramid(int pyramidSize)
        {
            for (int rowNo = 1; rowNo <= pyramidSize; rowNo++)
            {
                for (int spaceInRowIncrement=rowNo; spaceInRowIncrement<=pyramidSize; spaceInRowIncrement++)
                {
                    Console.Write(" ");
                }
                for (int starsInRowIncrement = 1; starsInRowIncrement<=2*rowNo-1; starsInRowIncrement++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }


        }
    }
}
