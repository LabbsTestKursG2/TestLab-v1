using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLab_v1;

namespace UnitTestProjectConcatArrayWithSpace
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodTest method = new MethodTest();

            //arrange
            string[] value = { "This", "is", "a", "test" };
            string[] sum = { "This is a test" };

            //act
            string[] result = method.ConcatArrayWithSpace(value);

            //assert
            CollectionAssert.AreEqual(sum, result);
        }
    }
}
