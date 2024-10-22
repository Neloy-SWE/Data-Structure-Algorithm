using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree
{
    internal class BinaryTreeQueue
    {
        private List<BinaryTreeNode> nodes = new List<BinaryTreeNode>();

        public void Enqueue(BinaryTreeNode node)
        {
            nodes.Add(node);
        }

        public BinaryTreeNode Dequeue()
        {
            BinaryTreeNode returnValue = nodes[0];
            nodes.RemoveAt(0);
            return returnValue;
        }

        public int Count()
        {
            return nodes.Count;
        }
    }
}
