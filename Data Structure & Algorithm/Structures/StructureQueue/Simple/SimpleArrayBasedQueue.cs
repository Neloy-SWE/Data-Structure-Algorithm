using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureQueue.Simple
{
    internal class SimpleArrayBasedQueue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int size;

        public SimpleArrayBasedQueue(int size)
        {
            this.size = size;
            this.elements = new int[size];
            this.front = 0;
            this.rear = -1;
        }

        public void Enqueue(int newElement)
        {
            Console.WriteLine("Equeue new element: " + newElement + "\n");
            if (rear == size - 1)
            {
                Console.WriteLine("Queue overflow!\n");
                return;
            }
            rear++;
            elements[rear] = newElement;
            Show();
        }

        void Show()
        {
            Console.Write("Show current queue:::  ");
            for (int i = front; i <= rear; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
