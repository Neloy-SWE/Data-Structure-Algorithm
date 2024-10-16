using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureQueue.Priority
{
    internal class PriorityQueue
    {
        class Element
        {
            public int data;
            public int priority;

            public Element(int data, int priority)
            {
                this.data = data;
                this.priority = priority;
            }
        }

        private Element[] elements;
        private int currentIndex;
        private int size;

        public PriorityQueue(int size)
        {
            Console.WriteLine(":::: Priority Queue ::::\n\n");
            this.elements = new Element[size];
            this.size = size;
            this.currentIndex = -1;
        }

        public void Enqueue(int data, int priority)
        {
            if (currentIndex + 1 < size) {
                currentIndex++;
                elements[currentIndex] = new(data, priority);


            }
        }
    }
}
