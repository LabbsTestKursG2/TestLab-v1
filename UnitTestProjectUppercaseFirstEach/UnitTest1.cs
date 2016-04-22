using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab_v1;

namespace UnitTestProjectUppercaseFirstEach
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodTest method = new MethodTest();

            //arrange
            string value = "this is a test";
            string sum = "This Is A Test";

            //act
            string result = method.UppercaseFirstEach(value);

            //assert
            Assert.AreEqual(sum, result);
        }
    }
}
