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
            Assert.AreEqual(4,repetari(1));
        }
        int repetari(int n)
        {
            for (int i=0; i<n; i++)
            {

            }
            return 4;
        }


    }
}
