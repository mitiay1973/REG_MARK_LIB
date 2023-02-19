using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        REG_MARK_LIB.Class1 class1 = new REG_MARK_LIB.Class1();
        [TestMethod]
        public void Proverka_number_B003XA52()
        {
            Assert.AreEqual(class1.CheckMark("В003ХА52"), true);
        }

        [TestMethod]
        public void Proverka_number_B000XA52()
        {
            Assert.AreEqual(class1.CheckMark("В000ХА52"), false);
        }
        [TestMethod]
        public void Proverka_sled_number_B003XA52()
        {
            Assert.AreEqual(class1.GetNextMarkAfter("В003ХА52"), "В004ХА52");
        }

        [TestMethod]
        public void Proverka_sled_number_B999XA52()
        {
            Assert.AreEqual(class1.GetNextMarkAfter("В999ХА52"), "В001ХВ52");
        }
    }
}
