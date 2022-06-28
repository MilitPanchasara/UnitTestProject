using NUnit.Framework;
using System;

namespace UnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.Write("This is test");
            //ProductsController.Get()
            Assert.Pass();
        }
    }
}