using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureQueue.Priority.Ascending
{
    internal class AscendingPriorityQueue
    {
        private Element[] elements;
        private int currentIndex;
        private int size;

        public AscendingPriorityQueue(int size)
        {
            Console.WriteLine(":::: Ascending Priority Queue ::::\n\n");
            elements = new Element[size];
            this.size = size;
            currentIndex = -1;
        }

        public void Enqueue(int data, int priority)
        {
            Console.WriteLine($"Enqueue new element: {data} with priority: {priority}:\n");
            if (currentIndex + 1 < size)
            {
                currentIndex++;
                elements[currentIndex] = new(data, priority);

                int j;
                int temp;
                Element tempElement;

                for (int i = 1; i <= currentIndex; i++)
                {
                    temp = elements[i].priority;
                    tempElement = elements[i];
                    j = i - 1;

                    while (j >= 0 && temp < elements[j].priority)
                    {
                        elements[j + 1] = elements[j];
                        j--;
                    }
                    elements[j + 1] = tempElement;
                }
                Console.WriteLine("Enqueue is done!\n");
                Show();

            }
            else
            {
                Console.WriteLine("Queue is full!\n");
            }
        }

        public void Dequeue()
        {
            Console.WriteLine("Dequeue start:\n");
            if (currentIndex == 0)
            {
                Console.WriteLine("You dequeued the last element!\n");
                currentIndex--;
                return;
            }
            else if (currentIndex + 1 > 0)
            {
                for (int i = 1; i <= currentIndex; i++)
                {
                    elements[i - 1] = elements[i];
                }
                currentIndex--;
            }
            else
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            Console.WriteLine("Dequeue is done!\n");
            Show();
        }

        void Show()
        {
            if (currentIndex < 0)
            {
                Console.WriteLine("Queue is empty!\n");
            }
            else
            {
                Console.Write("Current Queue::: ");
                for (int i = 0; i <= currentIndex; i++)
                {
                    Console.Write(elements[i].data + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
