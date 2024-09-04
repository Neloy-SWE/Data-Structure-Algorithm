using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly.Operations
{
    internal class DoublyInsert
    {
        public static DoublyNode InsertAtFront(DoublyNode node, int data)
        {

            DoublyNode newNode = new(data: data)
            {
                next = node
            };

            if (node.next != null)
            {
                node.previous = newNode;
            }

            return newNode;
        }

        public static DoublyNode InsertAtEnd(DoublyNode node, int data)
        {

            DoublyNode newNode = new(data: data);

            if (node == null)
            {
                node = newNode;
            }
            else
            {
                DoublyNode temporaryNode = node;

                while (temporaryNode.next != null)
                {
                    temporaryNode = temporaryNode.next;
                }

                temporaryNode.next = newNode;

                newNode.previous = temporaryNode;
            }
            return node;

        }

        public static DoublyNode InsertAtSpecificPosition(DoublyNode node, int position, int data)
        {
            DoublyNode newNode = new(data);
            if (position == 1)
            {
                newNode.next = node;
                if (node != null)
                {
                    node.previous = newNode;

                }
                return newNode;
            }

            DoublyNode currentNode = node;

            for (int i = 1; i < position - 1 && currentNode != null; i++)
            {
                currentNode = currentNode.next;
            }

            if (currentNode == null)
            {
                Console.WriteLine("Position is out of bounds.");
                return node!;
            }

            newNode.previous = currentNode;
            newNode.next = currentNode.next;
            currentNode.next = newNode;

            if (newNode.next != null)
            {
                newNode.next.previous = newNode;
            }
            return node!;
        }
    }
}
