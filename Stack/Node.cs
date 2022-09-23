using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node<T>
    {
        public T data { get; set; }
        public Node<T> previousNode { get; set; }

        public Node(T data, Node<T> previousNode)
        {
            this.data = data;
            this.previousNode = previousNode;
        }

    }
}
