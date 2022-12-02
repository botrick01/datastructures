using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Common;

namespace SortAlgorithmTests
{
    class SelectionSortTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestSelectionSort_5unsortedNodes_ListIsInCorrectOrder()
        {
            Common.LinkedList linkedList = new Common.LinkedList();
            linkedList.InsertLast(4);
            linkedList.InsertLast(1);
            linkedList.InsertLast(13);
            linkedList.InsertLast(8);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(new SelectionSort());
            linkedList.Sort();
            var node = linkedList.GetFirst();
            Assert.AreEqual(1, node.Value);
            Assert.AreEqual(2, node.nextNode.Value);
            Assert.AreEqual(4, node.nextNode.nextNode.Value);
            Assert.AreEqual(13, node.nextNode.nextNode.nextNode.nextNode.Value);
        }
    }
}
