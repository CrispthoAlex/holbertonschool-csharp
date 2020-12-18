using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(0, 3, 3)]
        [TestCase(-4, 1, -3)]
        [TestCase(-8, -3, -11)]
        public void TestAddIntegers(int a, int b, int result)
        {
            // Testing Add method
            Assert.AreEqual(Operations.Add(a, b), result);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}