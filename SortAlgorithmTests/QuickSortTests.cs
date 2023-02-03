using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SortAlgorithmTests
{
    public class QuickSortTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestQuickSort_Numbers_ListInCorecctOrder()
        {
            QuickSort quickSort = new QuickSort();
            int[] array = { 8, 6, 3, 7, 2, 9, 1, 4 };
            QuickSort.Sort(array, 1, array.Length - 1);
            Assert.AreEqual(array[0], 1);
            Assert.AreEqual(array[1], 2);
            Assert.AreEqual(array[2], 3);
            Assert.AreEqual(array[3], 4);
            Assert.AreEqual(array[4], 6);
            Assert.AreEqual(array[5], 7);
            Assert.AreEqual(array[6], 8);
            Assert.AreEqual(array[7], 9);
        }
    }

    public class QuickSort
    {
        public static int[] Sort(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                Sort(array, leftIndex, j);
            if (i < rightIndex)
                Sort(array, i, rightIndex);
            return array;
        }
    }
}
