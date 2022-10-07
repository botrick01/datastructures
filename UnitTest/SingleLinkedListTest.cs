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
            linkedList.insertFirst(1);
            linkedList.insertLast("last");
            linkedList.insertAt("middle", 1);
            linkedList.deleteFirst();
            Assert.AreEqual(linkedList.count(), 2);
        }
    }
}