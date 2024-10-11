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
            }
            else if (front > 0)
            {
                front--;
            }
            else
            {
                Console.WriteLine("Enqueue from front is not possible!\n");
                return;
            }
            elements[front] = newElement;
            Console.WriteLine("Enqueue done from front!\n");
            Show();
        }

        public void EnqueueRear(int newElement)
        {
            Console.WriteLine($"Enqueue new element: {newElement} from rear:\n");

            if (front == -1 && rear == -1)
            {
                front++;
                rear++;
            }
            else if (rear + 1 < size)
            {
                rear++;
            }
            else
            {
                Console.WriteLine("Enqueue from rear is not possible!\n");
                return;

            }
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

        public void DequeueRear()
        {
            Console.WriteLine("Dequeue from rear:\n");
            if (rear >= front)
            {
                rear--;
                Console.WriteLine("Dequeue done from rear:\n");
                if (rear < front)
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

        //public void GetFront()
        //{
        //    if (front)

        //}

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
