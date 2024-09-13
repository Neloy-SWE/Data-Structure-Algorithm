using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Circular.OperationCircularLinkedList
{
    internal class CircularInsert
    {
        public static CircularNode InsertInEmptyList(CircularNode node, int data)
        {

            Console.WriteLine("Insert in empty list:\n");
            if (node != null)
            {
                Console.WriteLine("Node is not empty!\n");
                return node;
            }
            CircularNode newNode = new(data);

            newNode.next = newNode;
            //ShowLinkedList.ShowCircular(newNode, "After insert the empty list");
            //return newNode; // returning newNode will create infinity loop.
            node = newNode;
            ShowLinkedList.ShowCircular(node, "After insert the empty list:");
            return node;
        }

        public static CircularNode InsertArFront(CircularNode node, int data)
        {
            Console.WriteLine("Insert at front:\n");
            CircularNode newNode = new(data);
            if (node == null)
            {
                newNode.next = newNode;
                return newNode;
            }

            newNode.next = node.next;
            node.next = newNode;
            ShowLinkedList.ShowCircular(node, "Inserted at front:");
            return node;
        }

        public static CircularNode InsertAtEnd(CircularNode node, int data)
        {
            Console.WriteLine("Insert at end:\n");
            CircularNode newNode = new(data);
            if (node == null)
            {
                node = newNode;
                newNode.next = newNode;
            }
            else
            {
                newNode.next = node.next;
                node.next = newNode;
                /* here value of newNode: 3->1->2->1->2....
                 * so by inserting newNode to the node.next (where node: 2->1->2->1...)
                 * we change next value of 2 to 3->1->2.
                 * so now if we traverse newNode: 3->1->2 here last value: 2 refer 3.
                 * that is how insertion at end complete.
                 */
                node = newNode;
            }
            ShowLinkedList.ShowCircular(node, "Inserted at end:");
            return node;
        }
    }
}
