using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bll;

namespace unittests
{
    [TestClass]
    public class UnitTest1
    {
        bll.Maths bl1 = new bll.Maths();
        double val;

        [TestMethod]
        public void TestMethod2()
        {
            val = bl1.Quadrada(2);
            Assert.AreEqual(4,val);
        }

        [TestMethod]
        public void TestMethod3()
        {
            val = bl1.Quadrada(3);
            Assert.AreEqual(9, val);
        }

        [TestMethod]
        public void TestMethod4()
        {
            val = bl1.Quadrada(4);
            Assert.AreEqual(16, val);
        }

        [TestMethod]
        public void TestMethod5()
        {
            val = bl1.Quadrada(5);
            Assert.AreEqual(25, val);
        }

    }
}
