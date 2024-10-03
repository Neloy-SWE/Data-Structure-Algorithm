using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureStack
{
    internal class DynamicStack
    {
        private ArrayList list;

        public DynamicStack()
        {
            this.list = new();
        }

        public void Push(int data)
        {
            list.Add(data);
            Console.WriteLine($"New element {data} is pushed!\n");
            Show();
        }

        public void Pop()
        {
            Console.WriteLine($"Element {list[list.Count - 1]} is poped!\n");
            list.RemoveAt(list.Count - 1);
            Show();
        }

        public void Top()
        {
            if (list.Count > 0)
            {
                Console.WriteLine($"Top of the stack is: {list[list.Count - 1]}\n");
            }
            else
            {
                Console.WriteLine("Stack is empty!\n");
            }
        }

        public void Show()
        {
            Console.Write("Current stack is::: ");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
