using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * basically binary tree can contain maximum 2 children.
 */

namespace Data_Structure___Algorithm.Structures.StructureTree.BinaryTree
{
    internal class BinaryTreeNode
    {
        public int data;
        public BinaryTreeNode left;
        public BinaryTreeNode right;

        public BinaryTreeNode(int data)
        {
            this.data = data;
            this.left = null!;
            this.right = null!;
        }
    }
}
