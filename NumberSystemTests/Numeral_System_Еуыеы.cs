using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NumberSystems;

namespace NumberSystemTests
{
    [TestClass]
    public class Numeral_System_Еуыеы
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                Numeral_System r = new Numeral_System();
                Assert.AreEqual("1011010", r.NumeralSystemCalc(2, "90"));
                Assert.AreEqual("132", r.NumeralSystemCalc(8, "90"));
                Assert.AreEqual("5v", r.NumeralSystemCalc(16, "90"));
            }
        }
    }
}