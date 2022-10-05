using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? nextNode;

        public Node(T value, Node<T>? _nextNode)
        {
            nextNode = _nextNode;
            Value = value;
        }
    }
}
