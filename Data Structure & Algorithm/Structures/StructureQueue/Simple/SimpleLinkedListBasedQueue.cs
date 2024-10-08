﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureQueue.Simple
{
    internal class SimpleLinkedListBasedQueue
    {
        private class Node
        {
            public int data;
            public Node next;

            public Node(int data)
            {
                this.data = data;
                next = null!;
            }
        }

        private Node node = null!;

        public void Enqueue(int data)
        {
            Console.WriteLine($"Enqueue new data: {data}\n");
            Node newNode = new(data);
            Node currentNode = node;
            if (node == null)
            {
                node = newNode;
            }
            else
            {
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                currentNode.next = newNode;
            }
            Show();
        }

        public void Dequeue()
        {
            Console.WriteLine("Dequeue operation start!\n");
            if (node == null)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            Console.WriteLine($"Dequeue data: {node!.data}\n");
            node = node.next;
            if (node == null)
            {
                Console.WriteLine("You remove the last element from the queue!\n");
                return;
            }
            Show();

        }

        public void Front()
        {
            Console.WriteLine("Show front:\n");
            if (node != null)
            {
                Console.WriteLine($"Front of the Queue is: {node.data}\n");
                return;
            }
            Console.WriteLine("Queue is empty!\n");
        }

        public void Rear()
        {
            Node currentNode = node;
            if (currentNode != null)
            {
                while (currentNode.next != null)
                {
                    currentNode = currentNode.next;
                }
                Console.WriteLine($"Rear of the Queue is: {currentNode.data}\n");
                return;
            }
            Console.WriteLine("Queue is empty!\n");
        }

        public void IsEmpty()
        {
            Console.WriteLine("Checking queue is empty or not:\n");
            if (node == null)
            {
                Console.WriteLine("Queue is empty!\n");
            }
            else
            {
                Console.WriteLine("Queue is not empty!\n");
            }
        }

        public void Show()
        {
            if (node == null)
            {
                Console.WriteLine("Queue is empty!\n");
                return;
            }
            Console.Write("Current Queue::: ");
            Node currentNode = node!;
            while (currentNode != null)
            {
                Console.Write(currentNode.data + " ");
                currentNode = currentNode.next;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
