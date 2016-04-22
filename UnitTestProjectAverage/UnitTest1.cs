using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab_v1;

namespace UnitTestProjectAverage
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodTest method = new MethodTest();

            //arrange
            int value1 = 5;
            int value2 = 3;
            int sum = 4;

            //act
            int result = method.Average(value1, value2);

            //assert
            Assert.AreEqual(sum, result);
        }
    }
}
