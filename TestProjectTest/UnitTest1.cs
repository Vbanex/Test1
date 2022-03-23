using NUnit.Framework;
using Test1;

namespace TestProjectTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test12345Equals11()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
           var result = Test1.ArrayInput.OperateOnArray(arr);
            Assert.AreEqual(result, 11);
        }

        [Test]
        public void Test152535Equals9()
        {
            int[] arr = { 15, 25, 35 };
            var result = Test1.ArrayInput.OperateOnArray(arr);
            Assert.AreEqual(result, 9);
        }


        [Test]
        public void Test88Equals12()
        {
            int[] arr = { 8, 8 };
            var result = Test1.ArrayInput.OperateOnArray(arr);
            Assert.AreEqual(result, 12);
        }
    }
}