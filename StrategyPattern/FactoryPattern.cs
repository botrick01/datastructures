using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class FactoryPattern
    {
        public static SortStrategy GetSortStrategy(string sortStrategy)
        {
            switch (sortStrategy)
            {
                case "InsertionSort":
                    return new InsertionSort();
                case "BubbleSort":
                    return new BubbleSort();
                case "SelectionSort":
                    return new SelectionSort();
                default:
                    return null;
            }
        }
    }
}
