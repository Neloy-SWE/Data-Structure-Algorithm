using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree
{
    internal class BinaryNode
    {
        public int data;
        public BinaryNode left;
        public BinaryNode right;

        public BinaryNode(int data)
        {
            this.data = data;
            this.left = null!;
            this.right = null!;
        }
    }
}
