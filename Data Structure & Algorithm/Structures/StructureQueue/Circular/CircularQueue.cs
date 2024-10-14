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
        }

    }
}
