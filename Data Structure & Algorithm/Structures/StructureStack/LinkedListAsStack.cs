using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureStack
{
    internal class LinkedListAsStack
    {
        private Node node = null!;
        private class Node(int data)
        {
            public int data { get; } = data;
            public Node next { get; set; } = null!;
        }

        public void Push(int data)
        {
            Node newNode = new(data);
            if (node == null)
            {
                node = newNode;
            }
            else
            {
                Node currentNode = node;
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
            Console.WriteLine($"{data} is pushed into the stack!\n");
            Show();
        }

        public void Show()
        {
            if (node == null)
            {
                Console.WriteLine("Stack is empty!\n");
                return;
            }
            Console.Write("Current stack::: ");
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
