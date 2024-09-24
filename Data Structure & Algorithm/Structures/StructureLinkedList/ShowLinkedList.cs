using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Circular;
using Data_Structure___Algorithm.Structures.StructureLinkedList.CircularDoubly;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Doubly;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Singly;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList
{
    internal class ShowLinkedList
    {

        // void ShowMessage(string message)
        static void ShowMessage(string message)
        {
            Console.WriteLine(message + "\n");
        }

        public static void ShowSingly(SinlglyNode node, string message)
        {
            //new ShowLinkedList().ShowMessage(message);
            ShowMessage(message);

            SinlglyNode currentNode = node;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + " ");
                currentNode = currentNode.next;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ShowDoubly(DoublyNode node, string message)
        {

            ShowMessage(message);

            DoublyNode firstNode = node;
            DoublyNode lastNode = null!;
            Console.WriteLine("Doubly linked list forward:");
            while (firstNode != null)
            {
                Console.Write(firstNode.data + " ");
                if (firstNode.next == null)
                {
                    lastNode = firstNode;
                }
                firstNode = firstNode.next!;
            }




            Console.WriteLine("\ndoubly linked list backward:");
            while (lastNode != null)
            {
                Console.Write(lastNode.data + " ");
                lastNode = lastNode.previous;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ShowCircular(CircularNode node, string message)
        {
            ShowMessage(message);
            if (node == null)
            {
                Console.WriteLine("Circular linked list is empty\n");
                return;
            }

            CircularNode head = node.next;
            while (true)
            {
                Console.Write(head.data + " ");
                head = head.next;
                if (head == node.next)
                {
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void ShowCircularDoubly(CircularDoublyNode node, string message)
        {
            ShowMessage(message);
            if (node == null)
            {
                Console.WriteLine("Circular doubly linked list is empty\n");
                return;
            }
            CircularDoublyNode currentNode = node;

            do
            {
                Console.Write(currentNode.data + " ");
                currentNode = currentNode.next;
            } while (currentNode != node);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
