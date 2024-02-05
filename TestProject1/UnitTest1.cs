using System.Diagnostics;
using UpperCase;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Debug.Write("test");
            // Assert
            Assert.AreEqual(8, 8);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Debug.Write("test2");
            // Assert
            Assert.AreEqual(8, 8);
        }
    }
}