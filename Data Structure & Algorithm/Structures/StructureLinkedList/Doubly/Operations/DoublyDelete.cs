using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly.Operations
{
    internal class DoublyDelete
    {
        public static DoublyNode DeleteAtFront(DoublyNode node)
        {
            if (node == null)
            {
                Console.WriteLine("There is no node");
                return node!;
            }
            DoublyNode currentNode = node;

            currentNode = currentNode.next;
            currentNode.previous = null!;
            return currentNode;

        }
    }
}
