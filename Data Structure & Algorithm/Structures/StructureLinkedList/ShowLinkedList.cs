using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Structure___Algorithm.Structures.StructureLinkedList.Singly;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList
{
    internal class ShowLinkedList
    {

        // void ShowMessage(string message)
        static void ShowMessage(string message)
        {
            Console.WriteLine("\n\n" + message);
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
        }
    }
}
