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
            QuickSort.Sort(array, 0, array.Length - 1);
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
        public static void Sort(int[] array, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int pivot = Partition(array, leftIndex, rightIndex);

                if (pivot > 1)
                {
                    Sort(array, leftIndex, pivot - 1);
                }
                if (pivot + 1 < rightIndex)
                {
                    Sort(array, pivot + 1, rightIndex);
                }
            }

        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}
