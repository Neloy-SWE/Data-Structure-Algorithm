using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureQueue.Simple
{
    internal class SimpleLinkedListBasedQueue
    {
        private class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null!;
            }
        }

        private Node? node;

        public void Enqueue(int data)
        {
            Console.WriteLine($"Inserting new data: {data}\n");
            Node newNode = new(data);
            if (node == null)
            {
                node = newNode;
            }
            else
            {
                while (node.next != null)
                {
                    newNode = node.next;
                }
                node.next = newNode;
            }
            Show();
        }

        public void Show()
        {
            if (node == null)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            Console.Write("Current Queue::: ");
            Node currentNode = node!;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + " ");
                currentNode = currentNode.next;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
