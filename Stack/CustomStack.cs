using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class CustomStack<T>
    {
        public Node<T> lastNode { get; set; }

        public void pop()
        {
            lastNode = lastNode.previousNode;
        }

        public void push(T data)
        {
            lastNode = new Node<T>(data, lastNode);
        }

        public int size()
        {
            int counter = 0;
            Node<T> node = lastNode;
            while (node != null)
            {
                node = node.previousNode;
                counter++;
            }
            return counter;
        }
    }
}

