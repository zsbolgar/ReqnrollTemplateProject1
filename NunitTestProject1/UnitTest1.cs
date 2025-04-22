using System;
using NUnit.Framework;

namespace NunitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Assert.Ignore("for ignore testing");
        }



        [Test]
        public void Test1()
        {
            Console.WriteLine("In the Test");
            Assert.Pass();
        }
    }
}