using Common;
using NUnit.Framework;

namespace SortAlgorithmTests
{
    public class InsertionSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestInsertionSortReverse_SortDecreasing_ListIsInCorrectOrder()
        {
            var linkedList = new Common.LinkedList();
            linkedList.InsertLast(4);
            linkedList.InsertLast(1);
            linkedList.InsertLast(13);
            linkedList.InsertLast(8);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(FactoryPattern.GetSortStrategy("InsertionSort"));
            linkedList.SortDescending();
            var node = linkedList.GetFirst();
            Assert.AreEqual(13, node.Value);
            Assert.AreEqual(8, node.nextNode.Value);
            Assert.AreEqual(4, node.nextNode.nextNode.Value);
            Assert.AreEqual(1, node.nextNode.nextNode.nextNode.nextNode.Value);
        }
        [Test]
        public void TestInsertionSort_Sort_ListIsInCorrectOrder()
        {
            Common.LinkedList linkedList = new Common.LinkedList();
            linkedList.InsertLast(4);
            linkedList.InsertLast(1);
            linkedList.InsertLast(13);
            linkedList.InsertLast(8);
            linkedList.InsertLast(2);
            linkedList.SetSortStrategy(new InsertionSort());
            linkedList.Sort();
            var node = linkedList.GetFirst();
            Assert.AreEqual(1, node.Value);
            Assert.AreEqual(2, node.nextNode.Value);
            Assert.AreEqual(4, node.nextNode.nextNode.Value);
            Assert.AreEqual(13, node.nextNode.nextNode.nextNode.nextNode.Value);
        }
    }
}