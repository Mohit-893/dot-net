using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkfact1()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.fact(5);
            Assert.AreEqual(res, 120);
            //double res2 = bm.add(10, 20);
            //Assert.AreEqual(res2, 300);
        }
        [TestMethod]
        public void checkfact2()
        {
            BasicMaths bm = new BasicMaths();
            double res = bm.fact(4);
            Assert.AreEqual(res, 24);
        }

        [TestMethod]
        public void checkprime1()
        {
            BasicMaths bm = new BasicMaths();
            bool res = bm.prime(5);
            Assert.AreEqual(res, true);
        }

        [TestMethod]
        public void checkprime2()
        {
            BasicMaths bm = new BasicMaths();
            bool res = bm.prime(15);
            Assert.AreEqual(res, false);
        }
    }
}
