using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class InsertionSortReverse : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            Node currentNode = list.GetFirst().nextNode;
            while (currentNode != null)
            {
                for (var cur = list.GetFirst(); cur != null; cur = cur.nextNode)
                {
                    if (cur == currentNode)
                        break;
                    if ((int)cur.Value > (int)currentNode.Value)
                        continue;
                    (cur.Value, currentNode.Value) = (currentNode.Value, cur.Value);
                }

                currentNode = currentNode.nextNode;
            }
        }
    }
}
