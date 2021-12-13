using NUnit.Framework;
using System;
using MyClass;
namespace testMyClassCustomMultStr
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestMethodMultStr()
        {
            string s = "To";
            int c = 4;
            string expected = "ToToToTo";
            ClassCustom o = new ClassCustom();
            string actual = o.MultStr(s, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
