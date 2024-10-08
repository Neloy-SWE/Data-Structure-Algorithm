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
            Console.WriteLine("Enqueue done!\n");
            Show();
        }

        public void Dequeue()
        {

            if (front == rear + 1)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            Console.WriteLine("Dequeue " + elements[front] + "\n");
            for (int i = 0; i < rear; i++)
            {
                elements[i] = elements[i + 1];
            }
            rear--;
            if (front == rear + 1)
            {
                Console.WriteLine("Last element dequeue done!\n");
            }
            else
            {
                Console.WriteLine("Dequeue done!\n");
                Show();
            }

        }

        public void Front()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            Console.WriteLine($"Front of the queue is: {elements[front]}\n");
        }

        public void Rear()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            Console.WriteLine($"Rear of the queue is: {elements[rear]}\n");
        }

        public void IsEmpty()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            Console.WriteLine("Queue is not empty!\n");
            Show();
        }

        public void IsFull()
        {
            if (rear + 1 == size)
            {
                Console.WriteLine("Queue is full!\n");
                return;
            }
            Console.WriteLine("Queue is not full!\n");
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
