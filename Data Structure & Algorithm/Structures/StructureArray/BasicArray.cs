using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureArray


// basis of size: fixed, dynamic
{
    internal class BasicArray
    {
        // declaration of array:

        int[] arr1;
        char[] arr2;
        double[] arr3;


        // declarration and initialization:
        int[] arr4 = [1, 2, 3, 4,];



        // fixed size array:
        int[] arr5 = new int[5]; // here we have define the size: 5

        // other ways:
        int[] arr6 = [1, 2, 3, 4,];


        // dynamic:
        ArrayList arr7 = new ArrayList();
        // we can add any type of data in arr7. ArrayList is non generic. there is no fixed length of arr7.
        // ref: https://www.c-sharpcorner.com/article/difference-between-array-and-arraylist-in-c-sharp/

        public void initializeHelper()
        {
            // we can initialize value according to index.
            arr5[0] = 1;
            arr5[1] = 2;
            arr5[2] = 3;
            arr5[3] = 3;
            arr5[4] = 3;
            //arr5[5] = 3; // System.IndexOutOfRangeException, because it has fixed sise: 5

            // we can also initialize value like this at once later after declaration.
            arr1 = [1, 2, 3];
        }


    }
}
