using LinkedList;
using NUnit.Framework;

namespace UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SingleLinkedListTest()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.insertLast(0);
            linkedList.InsertAfter(1, 0);
            Assert.AreEqual(linkedList.count(), 2);
            linkedList.DeleteNode(0);
            Assert.AreEqual(linkedList.count(), 1);
        }
    }
}