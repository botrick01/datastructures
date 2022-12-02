using NUnit.Framework;
using SingleLinkedListBasedStack;

namespace SingleLinkedListBasedStackTests
{
    public class SingleLinkedListBasedStackTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Push_ThreeElements_StackOrderOK()
        {
            SingleLinkedListBasedStack.SingleLinkedListBasedStack stack = new SingleLinkedListBasedStack.SingleLinkedListBasedStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(stack.ToString(), "1\n2\n3");
        }

        [Test]
        public void PushAndPop_PushThreeTimesPoPonce_TwoElementsInStackLastOneRemoved()
        {
            SingleLinkedListBasedStack.SingleLinkedListBasedStack stack = new SingleLinkedListBasedStack.SingleLinkedListBasedStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            var last = stack.Pop();
            Assert.AreEqual(last.Value, 3);
            Assert.AreEqual(stack.ToString(), "1\n2");
        }
    }
}