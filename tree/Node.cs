using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    public class Node
    {
        public int Value { get; set; }
        public Node? left;
        public Node? right;

        public Node(int value, Node? leftNode, Node? rightNode)
        {
            left = leftNode;
            right = rightNode;
            Value = value;
        }
    }
}
