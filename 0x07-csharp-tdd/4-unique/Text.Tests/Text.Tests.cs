using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("Hello World", 0)]
        [TestCase("Hello there", 4)]
        [TestCase("Hello Ol He", -1)]
        [TestCase("", -1)]
        public void TestUniqueChar(string s, int check)
        {
            Assert.AreEqual(Str.UniqueChar(s), check);
        }
    }
}