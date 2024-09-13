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
            //ShowLinkedList.ShowCircular(newNode, "Insert in empty list: node2 method test with empty list");
            //return newNode;
            node = newNode;
            ShowLinkedList.ShowCircular(node, "After insert the empty list");
            return node;
        }
    }
}
