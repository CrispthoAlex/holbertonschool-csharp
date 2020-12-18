using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestEmptyStr()
        {
            Assert.AreEqual(Str.IsPalindrome(""), true);
        }
        
        [TestCase("Tenet", true)]
        [TestCase("A man, a plan, a canal: Panama", true)]
        [TestCase("Holbies", false)]
        public void TestIsPalindrome(string s, bool check)
        {
            Assert.AreEqual(Str.IsPalindrome(s), check);
        }
    }
}