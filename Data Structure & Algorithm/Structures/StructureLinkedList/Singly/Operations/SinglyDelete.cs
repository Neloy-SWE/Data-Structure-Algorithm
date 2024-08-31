using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Singly.Operations
{
    internal class SinglyDelete
    {
        public static SinlglyNode DeleteAtFront(SinlglyNode node)
        {
            if (node == null)
            {
                return null!;
            }
            return node.next;

        }

        public static SinlglyNode DeleteAtEnd(SinlglyNode node)
        {
            if (node == null) { return null!; }

            if (node.next == null) { return null!; }

            SinlglyNode secondLastNode = node;

            while (secondLastNode.next.next != null)
            {
                secondLastNode = secondLastNode.next;
            }

            secondLastNode.next = null!;
            return node;

        }

        public static SinlglyNode DeleteAtPostion(SinlglyNode node, int position)
        {
            if (node == null)
            {
                return node!;
            }
            SinlglyNode temporaryNode = node;

            if (position == 1)
            {
                return node.next;
            }

            SinlglyNode previousNode = null!;
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
