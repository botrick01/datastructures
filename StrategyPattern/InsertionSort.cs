using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Common
{
    public class InsertionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            InsertionSortStrategy(list, false);
        }
        public override void SortDescending(IMyList list)
        {
            InsertionSortStrategy(list, true);
        }
        public void InsertionSortStrategy(IMyList list, bool reverse)
        {
            Node currentNode = list.GetFirst().nextNode;
            while (currentNode != null)
            {
                for (var cur = list.GetFirst(); cur != null; cur = cur.nextNode)
                {
                    if (cur == currentNode)
                        break;
                    if ((int)cur.Value < (int)currentNode.Value)
                        continue;
                    (cur.Value, currentNode.Value) = (currentNode.Value, cur.Value);
                }

                currentNode = currentNode.nextNode;
            }
        }
    }
}
