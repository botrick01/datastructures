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
        public void InsertLast_MultipleElements_ElementsAddedAtLastPosition()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.InsertLast(0);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            var node = linkedList.GetNode(0);
            Assert.AreEqual(node.Value, 0);
            Assert.AreEqual(node.nextNode.Value, 1);
        }

        [Test]
        public void InsertFirst_MultipleElements_ElementIsAddedAtFirstPosition()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(0);
            var node = linkedList.GetNode(0);
            Assert.AreEqual(0, node.Value);
            Assert.AreEqual(1, node.nextNode.Value);
        }

        [Test]
        public void InsertAfter_MultipleElements_ElementIsAddedAtRightPosition()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(0);
            linkedList.InsertAfter(10, 0);
            var node = linkedList.GetNode(0);
            Assert.AreEqual(10, node.nextNode.Value);
        }
        [Test]
        public void DeleteNode_MultipleElements_RightElementIsDeleted()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.InsertFirst(2);
            linkedList.InsertFirst(1);
            linkedList.InsertFirst(0);
            linkedList.DeleteNode(1);
            var node = linkedList.GetNode(1);
            Assert.AreEqual(null, node?.Value);
        }
        [Test]
        public void DeleteNode_OneElement_HeadIsDeleted()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
            linkedList.InsertFirst(0);
            linkedList.DeleteNode(0);
            int i = linkedList.Count();
            Assert.AreEqual(0, i);
        }

        [Test]
        public void DeleteNode_EmtyList_NoExeptionIsThrown()
        {
            LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
        }
    }
}