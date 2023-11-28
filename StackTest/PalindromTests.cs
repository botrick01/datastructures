using Stack;

namespace StackTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckPalindrom_APalindrom_True()
        {
            Assert.That(Palindrom.CheckPalindrom("Otto"), Is.True);
        }

        [Test]
        public void CheckPalindrom_NoPalindrom_False()
        {
            Assert.That(Palindrom.CheckPalindrom("Patrick"), Is.False);
        }
    }
}