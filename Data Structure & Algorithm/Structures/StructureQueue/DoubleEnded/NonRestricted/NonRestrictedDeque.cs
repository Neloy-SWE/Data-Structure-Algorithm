using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 This queue is not follows circular concept.
 if front is not available, though there are space, fornt insert is not possible.
 same as for rear
 */

namespace Data_Structure___Algorithm.Structures.StructureQueue.DoubleEnded.NonRestricted
{
    internal class NonRestrictedDeque
    {
        private int[] elements;
        private int front;
        private int rear;
        private int size;


        public NonRestrictedDeque(int size)
        {
            this.size = size;
            this.elements = new int[size];
            this.front = -1;
            this.rear = -1;
        }

        public void EnqueueFront(int newElement)
        {
            Console.WriteLine($"Enqueue new element: {newElement} from front:\n");
            if (front == -1 && rear == -1)
            {
                front++;
                rear++;
                elements[front] = newElement;
            }
            else if (front > 0)
            {
                front--;
                elements[front] = newElement;
            }
            else
            {
                Console.WriteLine("Enqueue from front is not possible!\n");
                return;
            }
            Console.WriteLine("Enqueue done from front!\n");
            Show();
        }

        public void EnqueueRear(int newElement)
        {
            Console.WriteLine($"Enqueue new element: {newElement} from rear:\n");
            if (rear == size - 1)
            {
                Console.WriteLine("Enqueue from rear is not possible!\n");
                return;
            }
            rear++;
            elements[rear] = newElement;
            Console.WriteLine("Enqueue done from rear!\n");
            Show();
        }

        public void DequeueFront()
        {
            Console.WriteLine("Dequeue from front:\n");
            if (front <= rear)
            {
                front++;
                Console.WriteLine("Dequeue done from front:\n");
                if (front > rear)
                {
                    Console.WriteLine("You dequeue the last element!\n");
                }
                else
                {
                    Show();
                }
            }
            else
            {
                Console.WriteLine("Queue is empty!\n");
            }
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
