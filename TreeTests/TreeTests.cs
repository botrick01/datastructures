using NUnit.Framework;
using tree;

namespace TreeTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Insert_5Values_TreeIsCorrectlyGenerated()
        {
            Tree tree = new Tree();
            tree.Insert(5);
            tree.Insert(2);
            tree.Insert(9);
            tree.Insert(3);
            tree.Insert(6);
            tree.Print();
            Assert.AreEqual(tree.root.Value, 5);
            Assert.AreEqual(tree.root.left.Value, 2);
            Assert.AreEqual(tree.root.right.Value, 9);
            Assert.AreEqual(tree.root.left.right.Value, 3);
            Assert.AreEqual(tree.root.right.left.Value, 6);
        }
    }
}