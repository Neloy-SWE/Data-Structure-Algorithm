using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Circular.OperationCircularLinkedList
{
    internal class CircularSearch
    {
        public static void BasedOnPosition(CircularNode node, int position)
        {
            Console.WriteLine($"Start searching based on position ({position}):\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
            }
            CircularNode currentNode = node!;
            CircularNode tempNode = null!;
            int i;
            for (i = 1; i <= position && currentNode.next != node; i++)
            {
                if (i == position)
                {
                    tempNode = currentNode.next;
                    Console.WriteLine($"data at position: {position} is {tempNode.data}!\n");
                    return;
                }
                currentNode = currentNode.next;
            }
            if (i == position && currentNode.next == node)
            {
                Console.WriteLine($"data at position: {position} is {currentNode.next.data}!\n");
            }
            else
            {
                Console.WriteLine("Out of index!\n");
            }
        }
    }
}
