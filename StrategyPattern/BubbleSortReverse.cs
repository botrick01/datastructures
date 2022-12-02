using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BubbleSortReverse : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            bool switches = true;
            while (switches)
            {
                Node currentNode = list.GetFirst();
                switches = false;
                while (currentNode.nextNode != null)
                {
                    if ((int)currentNode.nextNode.Value > (int)currentNode.Value)
                    {
                        list.SwitchNodes(currentNode, currentNode.nextNode);
                        switches = true;
                    }
                    currentNode = currentNode.nextNode;
                }
            }
        }
    }
}
