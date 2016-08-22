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
        [Test]
        public void TestGetChoppedWalnutPrice()
        {
            var getprice = new PriceLogic();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 11.98m;
            var actual = getprice.GetPriceForIndividualIngredient("chopped walnuts"); //, filename);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestGetCinnamonPrice()
        {
            var getprice = new PriceLogic();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 2.44m;
            var actual = getprice.GetPriceForIndividualIngredient("cinnamon");//, filename);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestGetRedStarYeast()
        {
            var getprice = new PriceLogic();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 4.62m;
            var actual = getprice.GetPriceForIndividualIngredient("yeast");//, filename);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestGetAllPurposeFlourPrice()
        {
            var getprice = new PriceLogic();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 3.98m;
            var actual = getprice.GetPriceForIndividualIngredient("all purpose flour");//, filename);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPriceForCakeFlour()
        {
            var getprice = new PriceLogic();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 3.28m;
            var actual = getprice.GetPriceForIndividualIngredient("cake flour");//, filename);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPriceForOats()
        {
            var getprice = new PriceLogic();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 2.48m;
            var actual = getprice.GetPriceForIndividualIngredient("oats");//, filename);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPriceForMiniChocolateChips()
        {
            var getprice = new PriceLogic();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 2.71m;
            var actual = getprice.GetPriceForIndividualIngredient("mini morsels");//, filename);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPricePerOunceForFlour()
        {
            var getprice = new PriceLogic();
            var ratioDatabase = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
            var responseDatabase = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt"; ;
            var expected = .103m;
            var actual = getprice.GetPriceForOneOunceOfIngredient("cake flour", ratioDatabase, responseDatabase);
            Assert.AreEqual(expected, actual);
        }
    }
}
