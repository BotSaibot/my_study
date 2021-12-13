using NUnit.Framework;
using System;
using MyClass;
namespace testMyClassCustomAlg
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestMethodAlg()
        {
            double a = 60;
            double b = 1000;
            double expected = 16.67;
            ClassCustom o = new ClassCustom();
            double actual = o.Alg(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
