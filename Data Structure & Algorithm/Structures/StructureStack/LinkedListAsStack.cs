using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureStack
{
    internal class LinkedListAsStack
    {
        Node node = null!;
        private class Node
        {
            public int data;
            public Node next;
            Node(int data)
            {
                this.data = data;
                this.next = null!;
            }
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
                Console.Write(node!.data + " ");
                currentNode = currentNode.next;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
