using NUnit.Framework;
using System;
using MyClass;
namespace testMyClassMathSquareSC
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestMethodSC()
        {
            double a = 5;
            double expected = 78.5;
            ClassMathSquare o = new ClassMathSquare();
            double actual = o.SC(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
