using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Node
    {
        public object Value { get; set; }
        public Node? nextNode;

        public Node(object value, Node? _nextNode)
        {
            nextNode = _nextNode;
            Value = value;
        }
    }
}
