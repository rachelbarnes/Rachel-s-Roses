using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Roses
{
    [TestFixture]
    public class VolumeToWeightLogicTests
    {
        //[Test]
        //public void ConvertTestOuncesToCups()
        //{
        //    var vol2weight = new VolumeToWeightLogic();
        //    var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\TestingConversionFromCupsToOunces.txt";
        //    var actual = vol2weight.ConvertReadMeasuredOuncesToCups("flour", 25m, filename);
        //    var expected = "flour : 5 cups";
        //    Assert.AreEqual(expected, actual); 
        //}
        //[Test]
        //public void ConvertTestCupsToOunces()
        //{
        //    var vol2weight = new VolumeToWeightLogic(); 
        //    var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\TestingConversionFromCupsToOunces.txt";
        //    var actual = vol2weight.ConvertReadMeasuredCupsToOunces("flour", 3.5m, filename);
        //    var expected = "flour : 17.5";
        //    Assert.AreEqual(expected, actual); 
        //}
        //[Test]
        //public void ConvertMeasuredCupsToOunces()
        //{
        //    var vol2weight = new VolumeToWeightLogic(); 
        //    var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
        //    var actual = vol2weight.GetOuncesFromRatio("flour", 6.125m, filename);
        //    var expected = 30.625m;
        //    Assert.AreEqual(expected, actual); 
        //}

        //[Test] //this is ok failing. I want to make sure I can get the whole database. 
        //public void ReadRatiosFromDatabase()
        //{
        //    var vw = new VolumeToWeightLogic();
        //    var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
        //    var expected = new string[] { "salt", "10.72" };
        //    var actual = vw.ReadRatiosFromRatioDatabase(filename);
        //    Assert.AreEqual(expected, actual);
        //}
        [Test]
        public void ReadSpecificIngredient()
        {
            var vw = new VolumeToWeightLogic(); 
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
            var expected = "salt: 10.72"; // new string[] { "salt", "10.72" };
            var actual = vw.ReadIngredientRatio("salt", filename);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void ReadOuncesForSalt()
        {
            var vw = new VolumeToWeightLogic(); 
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
            var expected = 10.72m;
            var actual = vw.ReadOuncesForIngredient("salt", filename);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void ReadOuncesForBananas()
        {

            var vw = new VolumeToWeightLogic(); 
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
            var expected = 12m;
            var actual = vw.ReadOuncesForIngredient("bananas", filename);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void ReadOuncesForWhiteSugar()
        {
            var vw = new VolumeToWeightLogic(); 
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
            var expected = 7.1m;
            var actual = vw.ReadOuncesForIngredient("sugar, granulated", filename);
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void ReadOuncesForVanillaExtract()
        {
            var vw = new VolumeToWeightLogic(); 
            var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
            var expected = 6.86m;
            var actual = vw.ReadOuncesForIngredient("vanilla", filename);
            Assert.AreEqual(expected, actual); 
        }
        //this is here to test which one it would take. as per
        //suspision with my for loop, it takes the last one
        //[Test]
        //public void ReadOuncesForSugar()
        //{
        //    var vw = new VolumeToWeightLogic(); 
        //    var filename = @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
        //    var expected = 3.6m;
        //    var actual = vw.ReadOuncesForIngredient("sugar", filename);
        //    Assert.AreEqual(expected, actual); 
        //}
        [Test]
        public void CalculatePercentage2()
        {
            var vw = new VolumeToWeightLogic();
            var expected = .8m;
            var actual = vw.PercentageOfMeasuredCupsToStandardCups(("4/5"));
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void CalculateOuncesForOneAndAHalfCupsBananas()
        {
            var vw = new VolumeToWeightLogic();
            var filename =  @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
            var expected = 18m;
            var actual = vw.GetAmountOfOuncesUsed("bananas", "1.5", filename);
            Assert.AreEqual(expected, actual);  
        }
        [Test]
        public void CalculateOuncesForSixAndAnEighthCups()
        {
            var vw = new VolumeToWeightLogic();
            var filename =  @"C:\Users\Rachel\Documents\Visual Studio 2015\Projects\RachelsRoses\Rachel-s-Roses\VolumeToWeightIngredientData.txt";
            var expected = 31.25m;
            var actual = vw.GetAmountOfOuncesUsed("flour", "6.25", filename);
            Assert.AreEqual(expected, actual);  
        }
    }
}