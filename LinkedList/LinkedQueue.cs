using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class LinkedQueue<T>
    {
        private Node<T> _lastNode;

        public void Push(T value)
        {
            _lastNode = new Node<T>(value, _lastNode);
        }

        public void Pop()
        {
            _lastNode = _lastNode.previousNode;
        }

        public int Size()
        {
            Node<T> node = _lastNode;
            int i = 0;
            while (node != null)
            {
                i++;
                node = node.previousNode;
            }

            return i;
        }
    }
}
