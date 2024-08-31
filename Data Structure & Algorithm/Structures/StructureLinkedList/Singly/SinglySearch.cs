using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Singly
{
    internal class SinglySearch
    {
        public static void Get(Node node, int key)
        {
            bool isValue = false;
            int i = 1;
            if (node == null)
            {
                Console.WriteLine("Empty linked list");
            }

            Node currentNode = node;

            while (currentNode != null)
            {
                if (currentNode.data == key)
                {
                    isValue = true;
                    break;
                }
                currentNode = currentNode.next;
                i++;
            }

            if (isValue)
            {
                Console.WriteLine($"Value: {key} found at node: {i}");
            }
            else
            {
                Console.WriteLine($"Value: {key} is not found");
            }

        }
    }
}
