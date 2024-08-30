using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Singly
{
    internal class SinglyInsert
    {
        public static Node InsertAtFront(Node node, int data)
        {
            Node updateNode = new(data)
            {
                next = node
            };

            return updateNode;
        }


        public static Node InsertAtEnd(Node node, int data)
        {
            Node newNode = new(data);
            if (node == null)
            {
                return newNode;
            }
            Node lastNode = node;

            while (lastNode.next != null)
            {
                lastNode = lastNode.next;
            }

            lastNode.next = newNode;

            //return lastNode;
            return node;
            /*
             * retrun lastNode or node will return same value. that is how reference type value work. 
             * reference value is stored in heap memory. 
             * if you assign an object to another and change any of them then both of them will consume same value. 
             * because they do not drectly store value. they point to the same underlying object in the memory.
             * basically both of them are same object (refer the same object).
             */
        }

        public static Node InsertAtGivenNode(Node node, int data, int key)
        {
            Node currentNode = node;
            while (currentNode != null)
            {
                if (currentNode.data == key)
                {
                    break;
                }
                currentNode = currentNode.next;
            }

            if (currentNode == null)
            {
                Console.WriteLine("Key is not found");
                return node;
            }

            Node newNode = new(data);
            newNode.next = currentNode.next;
            currentNode.next = newNode;
            return currentNode;
        }

        public static Node InsertAtSpecificPosition(Node node, int position, int data)
        {

            Node newNode = new(data);
            if (position == 1)
            {
                newNode.next = node;
                return newNode;
            }

            Node currentNode = node;

            for (int i = 1; i<position - 1 && currentNode.next !=null; ++i)
            {
                
                currentNode = currentNode.next;
                ShowLinkedList.ShowSingly(currentNode);
                ShowLinkedList.ShowSingly(node);
            }

            if (currentNode == null)
            {
                Console.WriteLine("out of bounds");
                return node;
            }

            newNode.next = currentNode.next!;
            currentNode.next = newNode;
            return node;
        }
    }
}