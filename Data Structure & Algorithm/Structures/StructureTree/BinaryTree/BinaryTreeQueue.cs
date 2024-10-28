using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree
{
    internal class BinaryTreeQueue<T>
    {
        private List<T> nodes = new List<T>();

        public void Enqueue(T node)
        {
            nodes.Add(node);
        }

        public T Dequeue()
        {
            T returnValue = nodes[0];
            nodes.RemoveAt(0);
            return returnValue;
        }

        public int Count()
        {
            return nodes.Count;
        }
    }
}
