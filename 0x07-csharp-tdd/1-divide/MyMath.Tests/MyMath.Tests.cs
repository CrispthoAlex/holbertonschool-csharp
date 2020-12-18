using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        int[,] realMatrix;

        [SetUp]
        public void createMatrix()
        {
            realMatrix = new int[,]
            { 
                {0, 3, 6},
                {9, 12, 15},
                {18, 21, 24}
            };
        }
        
        [Test]
        public void TestMatrixNull()
        {
            Assert.IsNull(Matrix.Divide(null, 6));
        }
        
        [Test]
        public void TestMatrixbyZero()
        {
            Assert.IsNull(Matrix.Divide(realMatrix, 0));
        }
        
        [Test]
        public void TestMatrixby3()
        {
            int[,] hopeMatrix = new int[,]
            { 
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8}
            };
            Assert.AreEqual(Matrix.Divide(realMatrix, 3), hopeMatrix);
        }
    }
}