using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * we will follow insert from both end and delete from only rear
 * we will not follow any circular concept here.
 * we will use linear concept.
 */

namespace Data_Structure___Algorithm.Structures.StructureQueue.DoubleEnded.OutputRestricted
{
    internal class OutputRestrictedDeque
    {
        private int[] elements;
        private int front;
        private int rear;
        private int size;

        public OutputRestrictedDeque(int size)
        {
            Console.WriteLine(":::: Output restricted deque ::::\n\n");
            this.size = size;
            this.elements = new int[size];
            this.front = -1;
            this.rear = -1;
        }

        public void EnqueueFront(int newElement)
        {
            Console.WriteLine($"Enqueue new element: {newElement} from fornt:\n");
            if (front == 0 && rear + 1 == size)
            {
                Console.WriteLine("Queue is full!\n");
            }
            else
            {
                if (front == -1 && rear == -1)
                {
                    front++;
                    rear++;
                }
                else
                {
                    rear++;
                    for (int i = rear; i >= 1; i--)
                    {
                        elements[i] = elements[i - 1];
                    }
                }
                elements[front] = newElement;
                Console.WriteLine("Enqueue done!\n");
                Show();
            }
        }

        public void EnqueueRear(int newElement)
        {
            Console.WriteLine($"Enqueue new element: {newElement} from rear:\n");
            if (front == 0 && rear + 1 == size)
            {
                Console.WriteLine("Queue is full!\n");
                return;
            }
            if (front == -1 && rear == -1)
            {
                front++;
                rear++;
            }
            else if (rear + 1 < size)
            {
                rear++;
            }
            elements[rear] = newElement;
            Console.WriteLine("Enqueue done!\n");
            Show();
        }

        public void DequeueRear()
        {
            Console.WriteLine("Dequeue from rear:\n");
            if (rear == -1)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            else
            {
                rear--;
                if (rear == -1)
                {
                    Console.WriteLine("You dequeue the last element!\n");
                }
                else
                {
                    Show();
                }
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
