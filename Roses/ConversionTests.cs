using System;
using NUnit.Framework; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    [TestFixture]
    class ConversionTests
    {
        [Test]
        public void ConvertCToT()
        {
            var convert = new Convert();
            var actual = 16;
            Assert.AreEqual(convert.CupsToTablespoons(1), actual);
        }
        [Test]
        public void TestForCups()
        {
            var convert = new Convert();
            var actual = 32;
            Assert.AreEqual(convert.CupsToTablespoons(2), actual); 
        }
        //[Test]
        //public void ConvertCtoT2()
        //{
        //    var convert = new Convert();
        //    var actual = 2.33;
        //    Assert.AreEqual(convert.CupsToTablespoons(1/3), actual);
        //}
        [Test]
        public void ConverttToT()
        {
            var convert = new Convert();
            var actual = 1;
            Assert.AreEqual(convert.TeaspoonsToTablespoons(3), actual); 
        }
        //[Test]
        //public void ConverttTo2()
        //{
        //    var convert = new Convert();
        //    var actual = (2.33m);
        //    Assert.AreEqual(convert.TeaspoonsToTablespoons(5), actual);  
        //}
    }
}
