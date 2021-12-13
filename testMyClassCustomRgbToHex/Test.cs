using NUnit.Framework;
using System;
using MyClass;
namespace testMyClassCustomRgbToHex
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestMethodRgbToHex()
        {
            int r = 128;
            int g = 128;
            int b = 64;
            int expected = 8421440;
            ClassCustom o = new ClassCustom();
            int actual = o.RgbToHex(r, g, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
