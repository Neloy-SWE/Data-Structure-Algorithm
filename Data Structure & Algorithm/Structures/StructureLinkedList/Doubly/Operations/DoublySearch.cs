using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly.Operations
{
    internal class DoublySearch
    {
        public static void get(DoublyNode node, int position)
        {
            if (node == null)
            {
                Console.WriteLine("the node is null");
            }
            DoublyNode currentNode = node!;
            for (int i = 1; i < position && node != null; i++)
            {
                if (currentNode.next == null)
                {
                    currentNode = null!;
                    break;
                }
                currentNode = currentNode.next;
            }

            if (currentNode == null)
            {

                Console.WriteLine("Out of index");
            }
            else
            {
                Console.WriteLine($"At position: {position} data is: {currentNode.data}");
            }
        }
    }
}
