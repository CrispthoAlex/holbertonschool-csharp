using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        List<int> listNum;

        [Test]
        public void TestMaxEmptyList()
        {
            listNum = new List<int>() {  };
            Assert.AreEqual(Operations.Max(listNum), 0);
        }

        [Test]
        public void TestMaxNullList()
        {
            listNum = null;
            Assert.AreEqual(Operations.Max(listNum), 0);
        }
        
        [Test]
        public void TestMaxPositiveNumber()
        {
            listNum = new List<int>() {2, 4, 6};
            Assert.AreEqual(Operations.Max(listNum), 6);
        }

        [Test]
        public void TestMaxNegativeNumber()
        {
            listNum = new List<int>() {-2, -4, -6};
            Assert.AreEqual(Operations.Max(listNum), -2);
        }

        [Test]
        public void TestMaxNumber()
        {
            listNum = new List<int>() {2, -4, -6};
            Assert.AreEqual(Operations.Max(listNum), 2);
        }
    }
}