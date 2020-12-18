using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("", 0)]
        [TestCase(null, 0)]
        [TestCase("helloWorldOpenYourEyes", 5)]
        [TestCase("SOMEBODYHERETwelveDaysLeft", 3)]
        public void TestCamelCase(string s, int check)
        {
            Assert.AreEqual(Str.CamelCase(s), check);
        }
    }
}