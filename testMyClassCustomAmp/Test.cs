using NUnit.Framework;
using System;
using MyClass;
namespace testMyClassCustomAmp
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestMethodAmp()
        {
            double a = 30;
            double b = 1.3;
            double expected = 0.77;
            ClassCustom o = new ClassCustom();
            double actual = o.Amp(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
