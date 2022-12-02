using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BubbleSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            BubbleSortStrategy(list, false);
        }
        public override void SortDescending(IMyList list)
        {
            BubbleSortStrategy(list, true);
        }
        public void BubbleSortStrategy(IMyList list, bool descending)
        {
            bool switches = true;
            while (switches)
            {
                Node currentNode = list.GetFirst();
                switches = false;
                while (currentNode.nextNode != null)
                {
                    if(descending)
                    {
                        if ((int)currentNode.nextNode.Value > (int)currentNode.Value)
                        {
                            list.SwitchNodes(currentNode, currentNode.nextNode);
                            switches = true;
                        }
                    }
                    else
                    {
                        if ((int)currentNode.nextNode.Value < (int)currentNode.Value)
                        {
                            list.SwitchNodes(currentNode, currentNode.nextNode);
                            switches = true;
                        }
                    }
                    
                    currentNode = currentNode.nextNode;
                }
            }
        }
    }
}
