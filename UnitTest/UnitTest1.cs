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
        public void LinkedListTest()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.insertFirst(1);
            Assert.Pass();
        }
    }
}