using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Singly
{
    internal class SinglyDelete
    {
        public static Node DeleteAtFront(Node node)
        {
            if (node == null)
            {
                return null!;
            }
            return node.next;

        }

        public static Node DeleteAtEnd(Node node)
        {
            if (node == null) { return null!; }

            if (node.next == null) { return null!; }

            Node secondLastNode = node;

            while (secondLastNode.next.next != null)
            {
                secondLastNode = secondLastNode.next;
            }

            secondLastNode.next = null!;
            return node;

        }

        public static Node DeleteAtPostion(Node node, int position)
        {
            if (node == null)
            {
                return node!;
            }
            Node temporaryNode = node;

            if (position == 1)
            {
                return node.next;
            }

            Node previousNode = null!;
            for (int i = 1; i < position && temporaryNode != null; i++)
            {
                previousNode = temporaryNode;
                temporaryNode = temporaryNode.next;
            }

            if (temporaryNode != null)
            {
                previousNode.next = temporaryNode.next;
            }
            else
            {
                Console.WriteLine("Data not present");
            }

            return node;
        }
    }
}
