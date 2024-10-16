using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureQueue.Circular
{
    internal class Element
    {
        public int data;
            public int priority;

            public Element(int data, int priority)
            {
                this.data = data;
                this.priority = priority;
            }
    }
}
