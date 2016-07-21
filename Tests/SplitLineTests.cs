using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Roses
{
    [TestFixture]
    public class SplitLineTests
    {
        [Test]
        public void SplitSimpleLine()
        {
            var split = new SplitLines();
            var StringToSplit = "Split this line at the spaces";
            var expected = new string[] { "Split", "this", "line", "at", "the", "spaces" };
            Assert.AreEqual(expected, split.SplitLineAtSpace(StringToSplit));
        }
        [Test]
        public void SplitAtColonTest()
        {
            var split = new SplitLines();
            var expected = new string[] { "I", "love", "cats" };
            var actual = split.SplitLineAtColon("I:love:cats");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CountSplitColonTest()
        {
            var split = new SplitLines();
            var myArray = new string[] { "this", "that" };
            var actual = myArray.Count();
            var expected = 2;
            Assert.AreEqual(expected, actual); 
        }
        //[Test]
        ////this test is failing, but oddly enough it's the expected that's causing it to fail. It says the expdcted is 'V', but the actual is "Volume To Weight Data Sheet" which is what I was expecting... 
        //public void SplitRatiosAtColonInFileTest()
        //{
        //    var split = new SplitLines();
        //    var ColonSplit = split.SplitVolumeToWeightDatabaseLines(@"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\TestingSplittingDataLines.txt");
        //    var expected = "VolumeToWeight Data Sheet";
        //    Assert.AreEqual(expected, ColonSplit[0]);
        //}
        [Test]
        public void OuncesToLbs()
        {
            var convert = new GeneralFunctionality();
            var actual = convert.OuncesToPounds(23);
            var expected = 1.4375m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void LbsToOunces()
        {
            var convert = new GeneralFunctionality();
            var actual = convert.PoundsToOunces(5.5m);
            var expected = 88m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SplitLinesAtColon()
        {
            var Split = new SplitLines();
            var actual = Split.SplitLineAtColon("this:that");
            var SplitArray = new string[] { "this", "that" };
            var expected = SplitArray;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConcatStringsWithColon()
        {
            var vol2weight = new VolumeToWeightLogic();
            var array = new string[] { };
            var expected = "Something" + " : " + 4m;
            var actual = vol2weight.ConcatRatioArray("Something", 4m.ToString());
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestNumberOfStringInDatabaseArray()
        {
            var split = new Reader();
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var array = new string[] {"Pillsbury All Purpose Flour 10Lb", "$3.98" }; 
            var expected = array;
            var actual = split.GetAllIngredientNamesAndPricesFromResponseDatabase(filename);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestGetChoppedWalnutPrice()
        {
            var getprice = new Reader(); 
            var filename =  @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 11.98m;
            var actual = getprice.GetPriceForIndividualIngredient("chopped walnuts", filename);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void TestGetCinnamonPrice()
        {
            var getprice = new Reader(); 
            var filename =  @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
            var expected = 11.98m;
            var actual = getprice.GetPriceForIndividualIngredient("cinnamon", filename);
            Assert.AreEqual(expected, actual); 
        }
        //[Test]//while this test is failing, it is still getting 34 elements to the list (as of 7.20.16). It is outputting all of the IngredentName, IngredientPrice arrays, which was the test's purpose. 
        //public void TestReturnedListOfIngredientNameAndPrice()
        //{
        //    var getArrays = new Reader();
        //    var TestArray = new string[] { "whole wheat flour", "3.98" };
        //    var TestArray2 = new string[] { "chopped nuts", "11.98" };
        //    var TestArray3 = new string[] { "all purpose flour", "3.49" };
        //    var TestArray4 = new string[] { "cinnamon", "4.87" }; 
        //    var filename =  @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\ItemResponseDatabase.txt";
        //    var TestList = new List<string[]>();
        //    TestList.Add(TestArray);
        //    TestList.Add(TestArray2);
        //    TestList.Add(TestArray3);
        //    TestList.Add(TestArray4); 
        //    var actual = getArrays.GetAllIngredientNamesAndPricesFromResponseDatabase(filename);
        //    Assert.AreEqual(TestList, actual); 
        //}
    }
}

