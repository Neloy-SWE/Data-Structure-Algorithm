﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureStack
{
    // basically we are using array here which is a fixed size data structure
    // to use array we must declare the size of the array
    internal class FixedSizedStack
    {
        private int[] elements;
        private int top;
        private int maxLength;

        public FixedSizedStack(int size)
        {
            this.elements = new int[size];
            this.top = -1;
            this.maxLength = size;
        }

        public void IsEmpty()
        {
            if (top < 1)
            {
                Console.WriteLine("Stack is empty!\n");
            }
            else
            {
                Console.WriteLine($"Stack is not empty. Current size is {top}\n");
            }
        }
        public void Push(int elementValue)
        {
            if (top == maxLength - 1)
            {
                Console.WriteLine("Stack overflow!\n");
            }
            else
            {
                top++;
                elements[top] = elementValue;
                Console.WriteLine($"New element {elementValue} pushed\n");
                Show();
            }
        }

        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!\n");
            }
            else
            {
                Console.WriteLine($"Element {elements[top]} is poped!\n");
                elements[top] = 0;
                top--;
                Show();
            }
        }

        public void Top()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty!\n");
            }
            else
            {
                Console.WriteLine($"Top element of the stack is: {elements[top]}\n");
            }
        }

        public void IsFull()
        {
            if (top < maxLength - 1)
            {
                Console.WriteLine("Stack is not full yet!\n");
            }
            else
            {
                Console.WriteLine("Stack is full!\n");
            }
        }

        void Show()
        {
            Console.Write("Show current stack:::  ");
            for (int i = 0; i <= top; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
