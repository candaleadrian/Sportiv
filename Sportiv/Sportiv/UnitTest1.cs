using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sportiv
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Repetari1()
        {
            Assert.AreEqual(1,repetari(1));
        }
        [TestMethod]
        public void Repetari2()
        {
            Assert.AreEqual(1, repetari(2));
        }
        [TestMethod]
        public void Repetari3()
        {
            Assert.AreEqual(6,repetari(3));
        }
        int repetari(int n)
        {
            int counter = 0;
            for (int i=1; i==n; i++)
            {
                counter += i;
            }
            return counter;
        }
    }
}
