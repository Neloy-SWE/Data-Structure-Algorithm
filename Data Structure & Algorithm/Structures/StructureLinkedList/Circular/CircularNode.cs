using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.Circular
{
    internal class CircularNode
    {
        public int data;
        public CircularNode next;

        public CircularNode(int data)
        {
            this.data = data;
            this.next = null!;
        }
    }
}
