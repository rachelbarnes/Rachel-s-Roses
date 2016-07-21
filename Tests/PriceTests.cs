using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Roses
{
    [TestFixture]
    public class DivisorsTests
    {
        [Test]
        public void PricePerPoundTest()
        {
            var price = new PriceLogic();
            var expected = 4m;
            var actual = price.PricePerPound(4, 1);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PricePerPoundTest2()
        {
            var price = new PriceLogic();
            var expected = 3.5m;
            var actual = price.PricePerPound(7, 2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PricePerOunceTest()
        {
            var price = new PriceLogic();
            var expected = .1m;
            var actual = price.PricePerOunce(.20m, 2);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void PricePerOunceTest2()
        {
            var price = new PriceLogic();
            var expected = .026m;
            var actual = price.PricePerOunce(.13m, 5);
            Assert.AreEqual(expected, actual);
        }
        //[Test]
        //public void PricePerOunceStartingWithPounds()
        //{
        //    var price = new PriceLogic();
        //    var expected = .036m;
        //    var actual = price.PricePerOunceFromPound(4.25m, 7.4m);
        //    Assert.AreEqual(expected, actual);
        //}
        //you don't want to put the MakeRequset or calling to a website in your tests... tight coupling, can't work without internet, can deplete your usage rights to their website, someone can get access to your key...

      
        [Test] 
        public void TestingDataStructures()
        {
            var testResponse = new ItemResponse();
            var write = new Writer();
            testResponse.Name = "Flour";
            testResponse.ItemId = 27;
            testResponse.SalePrice = 4m;
            var actual = write.FormatString(testResponse); 
            var expected = "Flour: ITEM PRICE: $4: ITEM ID: 27";
            Assert.AreEqual(expected, actual);
        }
        //[Test]
        //public void GetPercentForMeasuredCupsToStandardOunces()
        //{
        //    var per = new PriceLogic();
        //    var expected = 3.25m;
        //    var accepted = per.DeterminePriceForOuncesUsed("flour", )
        //}
    }
}
