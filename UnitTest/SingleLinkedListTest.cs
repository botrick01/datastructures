using LinkedList;
using NUnit.Framework;

namespace UnitTest
{
    public class SingleLinkedListTest
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
        [Test]
        public void GetPreviousNode_MultipleElements_GetRightNode()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.InsertLast(0);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            var node = linkedList.GetPreviousNode(2);
            Assert.AreEqual(1, node.Value);
        }
        [Test]
        public void SwitchNodes_MultipleElements_SwitchedCorrect()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.InsertLast(0);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            linkedList.InsertLast(5);
            var node2 = linkedList.GetNode(2);
            var node4 = linkedList.GetNode(4);
            linkedList.SwitchNodes(node2, node4);
            var node1 = linkedList.GetNode(1);
            linkedList.PrintAllNodes();
            Assert.AreEqual(4, node1.nextNode.Value);
            Assert.AreEqual(2, node1.nextNode.nextNode.nextNode.Value);
        }
        [Test]
        public void SwitchNodes_MultipleElements_FirstNodeDoesNotExists()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.InsertLast(0);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            linkedList.InsertLast(5);
            var node2 = new Node(9, null);
            var node4 = linkedList.GetNode(4);
            linkedList.SwitchNodes(node2, node4);
            var node1 = linkedList.GetNode(1);
            Assert.AreEqual(2, node1.nextNode.Value);
            Assert.AreEqual(4, node1.nextNode.nextNode.nextNode.Value);
        }
        [Test]
        public void SwitchNodes_MultipleElements_SecondNodeDoesNotExists()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.InsertLast(0);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            linkedList.InsertLast(5);
            var node2 = linkedList.GetNode(2);
            var node4 = new Node(9, null);
            linkedList.SwitchNodes(node2, node4);
            var node1 = linkedList.GetNode(1);
            Assert.AreEqual(2, node1.nextNode.Value);
            Assert.AreEqual(4, node1.nextNode.nextNode.nextNode.Value);
        }
        [Test]
        public void SwitchNodes_MultipleElements_BothNodesDontExist()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.InsertLast(0);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            linkedList.InsertLast(5);
            var node2 = new Node(8, null);
            var node4 = new Node(9, null);
            linkedList.SwitchNodes(node2, node4);
            var node1 = linkedList.GetNode(1);
            Assert.AreEqual(2, node1.nextNode.Value);
            Assert.AreEqual(4, node1.nextNode.nextNode.nextNode.Value);
        }
        [Test]
        public void SwitchNodes_SwitchFirstAndLastNode_BothNodesDontExist()
        {
            var linkedList = new LinkedList.LinkedList();
            linkedList.InsertLast(0);
            linkedList.InsertLast(1);
            linkedList.InsertLast(2);
            linkedList.InsertLast(3);
            linkedList.InsertLast(4);
            linkedList.InsertLast(5);
            var node0 = linkedList.GetNode(0);
            var node5 = linkedList.GetNode(5);
            linkedList.SwitchNodes(node0, node5);
            var node = linkedList.head;
            Assert.AreEqual(5, node.Value);
            Assert.AreEqual(0, node.nextNode.nextNode.nextNode.nextNode.nextNode.Value);
        }
    }
}