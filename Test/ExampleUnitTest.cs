﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorld2
{
    [TestClass]
    public class ExampleUnitTest
    {
        [TestMethod]
        public void TestIncrement()
        {
            Assert.AreEqual(1, TestableCode.Increment(0));
        }
    }
}
