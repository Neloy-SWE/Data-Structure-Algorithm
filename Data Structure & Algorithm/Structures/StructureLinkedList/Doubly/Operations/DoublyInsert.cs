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
    }
}
