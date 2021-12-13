using NUnit.Framework;
using System;
using MyClass;
namespace testMyClassMathSquareST
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestMethodST()
        {
            double a = 5;
            double b = 2;
            double c = 4;
            double expected = 3.8;
            ClassMathSquare o = new ClassMathSquare();
            double actual = o.ST(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
