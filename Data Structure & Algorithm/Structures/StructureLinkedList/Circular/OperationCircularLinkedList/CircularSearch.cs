using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Circular.OperationCircularLinkedList
{
    internal class CircularSearch
    {
        public static void BasedOnPosition(CircularNode node, int position)
        {
            Console.WriteLine($"Start searching based on position ({position}):\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
            }
            CircularNode currentNode = node!;
            CircularNode tempNode = null!;
            int i;
            for (i = 1; i <= position && currentNode.next != node; i++)
            {
                if (i == position)
                {
                    tempNode = currentNode.next;
                    Console.WriteLine($"data at position: {position} is {tempNode.data}!\n");
                    return;
                }
                currentNode = currentNode.next;
            }
            if (i == position && currentNode.next == node)
            {
                Console.WriteLine($"data at position: {position} is {currentNode.next.data}!\n");
            }
            else
            {
                Console.WriteLine("Out of index!\n");
            }
        }

        public static void BasedOnValue(CircularNode node, int value)
        {
            Console.WriteLine($"Start searching based on value ({value}):\n");
            if (node == null)
            {
                Console.WriteLine("Linked list is empty!\n");
            }

            CircularNode currentNode = node!.next;
            int count = 1;
            while (currentNode.next != node)
            {
                if (currentNode.data == value)
                {
                    Console.WriteLine($"data {currentNode.data} is found at position: {count}!\n");
                    return;
                }
                currentNode = currentNode.next;
                count++;
            }
            if (currentNode.next == node && currentNode.data == value)
            {
                Console.WriteLine($"data {currentNode.data} is found at position: {count}!\n");
            }

            else if (currentNode.next.data == value)
            {
                //currentNode == node && currentNode.data == value
                //currentNode = currentNode.next;
                Console.WriteLine($"data {currentNode.next.data} is found at position: {count + 1}!\n");
            }
            else
            {
                Console.WriteLine("The value is not found!\n");
            }

        }
    }
}
