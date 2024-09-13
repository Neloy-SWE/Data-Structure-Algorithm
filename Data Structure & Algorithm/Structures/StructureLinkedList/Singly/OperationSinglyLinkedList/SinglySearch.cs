namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Singly.Operations
{
    internal class SinglySearch
    {
        public static void Get(SinlglyNode node, int key)
        {
            bool isValue = false;
            int i = 1;
            if (node == null)
            {
                Console.WriteLine("Empty linked list");
            }

            SinlglyNode currentNode = node!;

            while (currentNode != null)
            {
                if (currentNode.data == key)
                {
                    isValue = true;
                    break;
                }
                currentNode = currentNode.next;
                i++;
            }

            if (isValue)
            {
                Console.WriteLine($"Value: {key} found at node: {i}");
            }
            else
            {
                Console.WriteLine($"Value: {key} is not found");
            }

        }
    }
}
