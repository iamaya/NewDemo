using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestMethod1()
        {
            throw new NotImplementedException();
        }
    }
}
