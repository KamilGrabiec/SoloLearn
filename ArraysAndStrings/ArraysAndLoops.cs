using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    class ArraysAndLoops
    {

        public int[] EvenNumbersArray()
        {
            int[] evenNumbersArray = new int[10];
            for (int i=0; i<evenNumbersArray.Count(); i++)
            {
                evenNumbersArray[i] = i * 2;
            }
            return evenNumbersArray;
        }

        /// Create matrix 3 x 2
        public int[,] MultidmensionalArray()
        {
            int[,] surface = new int[4,3];
            for(int i =0; i<4; i++)
                for (int j=0; i<3; j++)
                {
                    surface[i, j] = i * j;
                }
            return surface;
        }
        ///Create array of arrays, number of column is defined. Each column may have different amount of rows  
        public int[][] JaggedArray()
        {
            int[][] arrayOfArrays = new int[3][]
            {
                new int[] {1,2,5,31,6},
                new int[] {2,6,5,8,9,0,4,6,89},
                new int[] {3,8}
            };
            return arrayOfArrays;
        }

        //Jagged Array of two-dimensional arrays. Could be list of surfaces
        public int[][,] SurfaceList()
        {
            int[][,] surfaceList = new int[3][,]
            {
                new int [1,1], //1 row one column
                new int [1,2], //1 row two columns
                new int [3,1]  //3 rows one column 
            };
            surfaceList[2][2, 0] = 5; // assigne value 5 to second array in second row and first column
            return surfaceList; 
        }


        public void DisplayArray()
        {
            int[] arrayToDisplay = EvenNumbersArray();
            for (int i=0; i<arrayToDisplay.Count(); i++)
            {
                Console.WriteLine(arrayToDisplay[i]);
            }
            ///The same with foreach loop
            foreach(var k in arrayToDisplay)
            {
                Console.WriteLine(k);
            }
        }


  
            

    }
}
