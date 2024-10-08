﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureLinkedList.CircularDoubly.OperationCircularDoublyLinkedList
{
    internal class CircularDoublyInsert
    {
        public static CircularDoublyNode InsertAtFront(CircularDoublyNode node, int data)
        {
            Console.WriteLine("Insert at front:\n");
            CircularDoublyNode newNode = new(data);

            if (node == null)
            {
                Console.WriteLine("Node is empty! inserting the first node:\n");
                newNode.next = newNode;
                newNode.previous = newNode;
                node = newNode;
            }
            else
            {
                CircularDoublyNode currentNode = node.previous;
                newNode.next = node;
                newNode.previous = currentNode;
                node.previous = newNode;
                currentNode.next = newNode;
                node = newNode;
            }
            ShowLinkedList.ShowCircularDoubly(node, "Inserted at front:");
            return node;
        }

        public static CircularDoublyNode InsertAtEnd(CircularDoublyNode node, int data)
        {
            Console.WriteLine("Insert at end:\n");
            CircularDoublyNode newNode = new(data);

            if (node == null)
            {
                Console.WriteLine("Node is empty! inserting the first node:\n");
                newNode.next = newNode;
                newNode.previous = newNode;
                node = newNode;
            }
            else
            {
                CircularDoublyNode currentNode = node.previous;
                newNode.next = node;
                newNode.previous = currentNode;
                node.previous = newNode;
                currentNode.next = newNode;
            }
            ShowLinkedList.ShowCircularDoubly(node, "Inserted at end:");
            return node;
        }

        public static CircularDoublyNode InsertAfterNode(CircularDoublyNode node, int data, int nodeData)
        {
            Console.WriteLine($"Insert {data} after node: {nodeData}:\n");
            CircularDoublyNode newNode = new(data);
            if (node == null)
            {
                Console.WriteLine("Node is empty!\n");
                return null!;
            }
            CircularDoublyNode currentNode = node;
            do
            {
                if (currentNode.data == nodeData)
                {
                    newNode.next = currentNode.next;
                    newNode.previous = currentNode;

                    currentNode.next.previous = newNode;
                    currentNode.next = newNode;

                    if (currentNode == node.previous)
                    {
                        node.previous = newNode;
                    }
                    ShowLinkedList.ShowCircularDoubly(node, $"{data} is inserted after node: {nodeData}");
                    return node;
                }
                currentNode = currentNode.next;
            } while (currentNode != node);
            Console.WriteLine($"Given node: {nodeData} is not found!\n");
            return node;
        }

        public static CircularDoublyNode InsertBeforeNode(CircularDoublyNode node, int data, int nodeData)
        {
            Console.WriteLine($"Insert {data} before node: {nodeData}:\n");
            CircularDoublyNode newNode = new(data);
            if (node == null)
            {
                Console.WriteLine("Node is empty!\n");
                return null!;
            }
            CircularDoublyNode currentNode = node;
            do
            {
                if (currentNode.data == nodeData)
                {
                    newNode.next = currentNode;
                    newNode.previous = currentNode.previous;

                    currentNode.previous.next = newNode;
                    currentNode.previous = newNode;

                    if (currentNode == node)
                    {
                        node = newNode;
                    }
                    ShowLinkedList.ShowCircularDoubly(node, $"{data} is inserted before node: {nodeData}");
                    return node;
                }
                currentNode = currentNode.next;
            } while (currentNode != node);
            Console.WriteLine($"Given node: {nodeData} is not found!\n");
            return node;
        }


        public static CircularDoublyNode InsertAtSpecificPosition(CircularDoublyNode node, int data, int position)
        {
            Console.WriteLine($"Insert {data} at position: {position}:\n");
            CircularDoublyNode newNode = new(data);
            if (node == null)
            {
                if (position > 1)
                {
                    Console.WriteLine("Node is empty!\n");
                    return null!;
                }

                newNode.next = newNode;
                newNode.previous = newNode;
                ShowLinkedList.ShowCircularDoubly(node!, $"{data} is inserted at the position: {position}");
                return newNode;
            }

            if (position == 1)
            {
                newNode.next = node;
                newNode.previous = node.previous;
                node.previous.next = newNode;
                node.previous = newNode;
                ShowLinkedList.ShowCircularDoubly(node, $"{data} is inserted at the position: {position}");
                return newNode;
            }

            CircularDoublyNode currentNode = node;
            for (int i = 1; i < position - 1; i++)
            {

                currentNode = currentNode.next;
                if (currentNode == node)
                {
                    Console.WriteLine("Out of range!\n");
                    return node;
                }
            }
            newNode.next = currentNode.next;
            newNode.previous = currentNode;

            if (currentNode.next != null)
            {
                currentNode.next.previous = newNode;
            }

            currentNode.next = newNode;
            ShowLinkedList.ShowCircularDoubly(node, $"{data} is inserted at the position: {position}");
            return node;
        }
    }
}
