using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab_v1;

namespace UnitTestProjectCapitalize
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodTest method = new MethodTest();

            //arrange
            string value = "this1 is a test";
            string sum = "This_Is_A_Test";

            //act
            string result = method.Capitalize(value);

            //assert
            Assert.AreEqual(sum, result);
        }
    }
}
