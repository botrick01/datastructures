using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace SingleLinkedListBasedStack
{
    public class SingleLinkedListBasedStack
    {
        private LinkedList internalList = new LinkedList();

        public Node Push(object argValue)
        {
            internalList.InsertLast(argValue);
            return internalList.GetNode(argValue);
        }

        public Node Pop()
        {
            return internalList.DeleteLast();
        }

        public override string ToString()
        {
            return internalList.ToString();
        }
    }
}
