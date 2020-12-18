using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("hello World, Open Your Eyes", 5)]
        [TestCase("hello There, 10 Days Left", 4)]
        [TestCase("techify4 Team Was Created", 3)]
        [TestCase("1 2 3 4 5", 0)]
        [TestCase("", 1)]
        [TestCase(null, 0)]
        public void TestCamelCase(string s, int check)
        {
            Assert.AreEqual(Str.CamelCase(s), check);
        }
    }
}