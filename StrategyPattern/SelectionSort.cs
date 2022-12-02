using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class SelectionSort : SortStrategy
    {
        public override void Sort(IMyList list)
        {
            SelectionSortStrategy(list, false);
        }
        public override void SortDescending(IMyList list)
        {
            SelectionSortStrategy(list, true);
        }
        public void SelectionSortStrategy(IMyList list, bool reverse)
        {
            Node current = list.GetFirst();
            while(current != null)
            {
                Node extremum = current;
                for(Node cur = current; cur != null; cur = cur.nextNode)
                {
                    if(reverse)
                    {
                        if ((int)cur.Value > (int)extremum.Value)
                        {
                            extremum = cur;
                        }
                    }
                    else
                    {
                        if((int)cur.Value < (int)extremum.Value)
                        {
                            extremum = cur;
                        }
                    }
                    
                }
                list.SwitchNodes(extremum, current);
                current = current.nextNode;
            }
        }
    }
}
