using Microsoft.VisualStudio.TestTools.UnitTesting;
using GetVowelCount;

namespace GetVowelCount_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_Alphabet()
        {
            Assert.AreEqual(5, Program.GetVowelCount("ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
        }
        [TestMethod]
        public void TestMethod_Case()
        {
            Assert.AreEqual(5, Program.GetVowelCount("A a I e U"));
        }
        [TestMethod]
        public void TestMethod_Spaces()
        {
            Assert.AreEqual(5, Program.GetVowelCount("A a I e U"));
        }
    }
}
