using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList
{
    internal class ShowLinkedList
    {

        // void ShowMessage(string message)
        static void ShowMessage(string message)
        {
            Console.WriteLine("\n\n" + message);
        }

        public static void ShowSingly(Node node, string message)
        {
            //new ShowLinkedList().ShowMessage(message);
            ShowMessage(message);

            Node currentNode = node;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + " ");
                currentNode = currentNode.next;
            }
            Console.WriteLine();
        }
    }
}
