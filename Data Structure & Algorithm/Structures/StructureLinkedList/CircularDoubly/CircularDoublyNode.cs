using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.CircularDoubly
{
    internal class CircularDoublyNode
    {
        public CircularDoublyNode previous;
        public int data;
        public CircularDoublyNode next;

        public CircularDoublyNode(int data)
        {
            this.data = data;
            this.previous = null!;
            this.next = null!;
        }
    }
}
