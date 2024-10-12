using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * basically we know that, queue maintain FIFO. 
 * here data insert from rear and remove from front.
 * 
 * now lets understand input restriction:
 * for deque insert and remove possible using both end
 * and as we know basically data insert from rear, so
 * we stop inserting from rear. we will only insert from front
 * and remove by both end.
 * 
 * also some sources say that we can insert only using rear 
 * and remove by both end.
 * 
 * 
 * we will not follow any circular concept here.
 * we will use linear concept.
 * we will shift elements to the rear while removing using front.
 */

namespace Data_Structure___Algorithm.Structures.StructureQueue.DoubleEnded.InputRestricted
{
    internal class InputRestrictedDeque
    {
        private int[] elements;
        private int front;
        private int rear;
        private int size;

        public InputRestrictedDeque(int size)
        {
            this.size = size;
            this.elements = new int[size];
            this.front = -1;
            this.rear = -1;
        }

        public void Enqueue(int newElement)
        {
            Console.WriteLine($"Enqueue new element: {newElement} (from front only):\n");
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
                else if (front > 0)
                {
                    front--;
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
