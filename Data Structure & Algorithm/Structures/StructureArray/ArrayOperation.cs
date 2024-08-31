namespace Data_Structure___Algorithm.Structures.StructureArray
{
    internal class ArrayOperation
    {
        int[] fixedSizeArray = [1, 2, 3, 4, 5];

        public int[] GetFixedSizedArray()
        {
            return fixedSizeArray;
        }


        public void Traverse()
        {
            Console.WriteLine("Show all elements of array");
            for (int i = 0; i < fixedSizeArray.Length; i++)
            {
                Console.Write(fixedSizeArray[i] + " ");
            }
            Console.WriteLine();
        }

        public void InsertElement(int[] arr, int n, int x, int pos)
        {
            Console.WriteLine($"Insert element: {x} at position of: {pos}");
            for (int i = n - 2; i >= pos; i--)
            {
                arr[i + 1] = arr[i];
            }

            arr[pos] = x;
            Traverse();
            Console.WriteLine();
        }

        public int FindElement(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    Console.WriteLine($"Element found at: {i} index");
                    return i;
                }
            }
            Console.WriteLine("No element found");
            return -1;
        }

        public void Deletion(int[] arr, int element)
        {
            Console.WriteLine($"Delete an element: {element}");
            int elemntIndex = FindElement(arr, element);

            for (int i = elemntIndex; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            int[] tempArr = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length - 1; i++)
            {
                tempArr[i] = arr[i];
            }

            fixedSizeArray = tempArr;


            Traverse();
            Console.WriteLine();
        }
    }
}
