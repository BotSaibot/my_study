using NUnit.Framework;
using System;
using MyClass;
namespace testMyClassMathSquareSQ
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestMethodSQ()
        {
            double a = 5;
            double b = 2;
            double expected = 10;
            ClassMathSquare o = new ClassMathSquare();
            double actual = o.SQ(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
