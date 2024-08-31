namespace Data_Structure___Algorithm.Structures.StructureArray
{
    // basis of dimensions
    // you can find 1D array in BasicArray class
    internal class DimensionalArray
    {
        // 2D:
        // declare
        int[,]? arr1;

        void Initialize()
        {
            arr1 = new int[2, 3] { { 1, 4, 2 }, { 3, 6, 8 } };
        }

        public void GetDimensionalArray()
        {
            Initialize();
            Console.WriteLine("Print 2D array");

            for (int i = 0; i < arr1!.GetLength(0); i++)
            {

                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
