using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureQueue.Circular
{
    internal class CircularQueue
    {
        private int[] elements;
        private int front;
        private int rear;
        private int size;

        public CircularQueue(int size)
        {
            Console.WriteLine(":::: Circular Queue ::::\n\n");
            this.size = size;
            this.elements = new int[size];
            this.front = -1;
            this.rear = -1;
        }

        public void Enqueue(int newElement)
        {
            Console.WriteLine($"Enqueue new element: {newElement}:\n");
            if (rear + 1 == front || (front == 0 && rear + 1 == size))
            {
                Console.WriteLine("Queue is full!\n");
                return;
            }
            if (front == -1 && rear == -1)
            {
                front++;
                rear++;
                elements[rear] = newElement;
            }
            else if (rear + 1 < size)
            {
                rear++;
            }
            else if (front > 0)
            {
                rear = 0;
            }
            elements[rear] = newElement;
            Console.WriteLine("Enqueue done!\n");
            Show();
        }

        public void Dequeue()
        {
            Console.WriteLine("Dequeue start:\n");
            if (rear == -1 && front == -1)
            {
                Console.WriteLine("Queue is empty!\n");
            }
            else
            {
                front++;
                Console.WriteLine("Dequeue done!\n");
                if (front == size)
                {
                    front = 0;
                }
                else if (front == rear + 1)
                {
                    front = -1;
                    rear = -1;
                    Console.WriteLine("You removed the last elements of the queue!\n");
                    return;
                }
                Show();
            }

        }

        public void Status()
        {
            Console.WriteLine("Showing status:\n");
            if (rear == -1 && front == -1)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            else
            {
                Show();
                Console.WriteLine($"The front element is: {elements[front]}\n");
                Console.WriteLine($"The rear element is: {elements[rear]}\n");
                if (rear + 1 == front || (front == 0 && rear + 1 == size))
                {
                    Console.WriteLine("Queue is full!\n");
                }
                else
                {
                    Console.WriteLine("Enqueue possible in available positions!\n");
                }
                


            }
        }

        void Show()
        {
            if (rear == -1 && front == -1)
            {
                Console.WriteLine("Queue is empty!\n");
            }
            else
            {
                Console.Write("Current queue::: ");
                if (front <= rear)
                {
                    for (int i = front; i <= rear; i++)
                    {
                        Console.Write(elements[i] + " ");
                    }
                }
                else
                {
                    for (int i = front; i < size; i++)
                    {
                        Console.Write(elements[i] + " ");
                    }
                    for (int i = 0; i <= rear; i++)
                    {
                        Console.Write(elements[i] + " ");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
