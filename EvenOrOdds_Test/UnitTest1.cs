using Microsoft.VisualStudio.TestTools.UnitTesting;
using EvenOrOdds;

namespace EvenOrOdds_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_PositiveNr()
        {
            Assert.AreEqual("Even", Program.EvenOrOdd(800));
        }
        [TestMethod]
        public void TestMethod_NegativeNr()
        {
            Assert.AreEqual("Odd", Program.EvenOrOdd(801));
        }
    }
}
