using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Roses
{
    [TestFixture]
    public class ConvertRecipeToTablespoonsTests
    {
        [Test]
        public void ConvertFromCupsToTablespoonsTest()
        {
            var CtT = new ConvertCandtToTablespoons();
            var line = "1 cup sugar";
            var actual = CtT.ConvertCupsToTablespoons(line);
            var expected = "16.00 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFromCupsToTablespoonsTestDecimalPlaces()
        {
            var CtT = new ConvertCandtToTablespoons();
            var line = ".5 cups baking cocoa";
            var actual = CtT.ConvertCupsToTablespoons(line);
            var expected = "8.00 tablespoons";
            Assert.AreEqual(expected, actual);
            //something is incorrect with my decimal places, hence the 2 extra chars
        }
        [Test]
        public void ConvertFromCupsToTablespoonsTestDecimalPlaces2()
        {
            var CtT = new ConvertCandtToTablespoons();
            var line = ".25 cups baking cocoa";
            var actual = CtT.ConvertCupsToTablespoons(line);
            var expected = "4.00 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFromCupsToTablespoonsTestDecimalPlaces3()
        {
            var CtT = new ConvertCandtToTablespoons();
            var line = ".125 cups baking cocoa";
            var actual = CtT.ConvertCupsToTablespoons(line);
            var expected = "2.00 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        //it's actually taking the amount of decimal places that originates with the starting cup size.... interesting. How do I fix this? 
        [Test]
        public void ConvertFromttoT()
        {
            var CtT = new ConvertCandtToTablespoons();
            var line = "3 teaspoons baking powder";
            var actual = CtT.ConvertTeaspoonsToTablespoons(line);
            var expected = "1.00 tablespoon";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void convertfromtToT2()
        {
            var c2t = new ConvertCandtToTablespoons();
            var line = "2 teapsoons baking soda";
            var actual = c2t.ConvertTeaspoonsToTablespoons(line);
            var expected = ".67 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFromtToT3()
        {
            var c2t = new ConvertCandtToTablespoons();
            var line = ".5 teaspoons salt";
            var actual = c2t.ConvertTeaspoonsToTablespoons(line);
            var expected = ".17 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Tablespoons()
        {
            var c2t = new ConvertCandtToTablespoons();
            var line = "4.333 tablespoons";
            var actual = c2t.RoundTablespoonMeasurement(line);
            var expected = "4.33 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        //when the time comes, we can do tablespoons to cups, but for adjusting the recipe based off of hte multiplier, we can do tablespoons. 

        [Test]
        public void TestingFunctionalityOfConversionToDecimalAfterStringSplit()
        {
            var myArray = new string[] { "1", "3" };
            var actual = Convert.ToDecimal(myArray[1]);
            var expected = 3m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestingFunctionalityOfMoreDecimalPlacesAfterStringSplit()
        {
            var myArray = new string[] { "1.37859", "3.14159" };
            var actual = Convert.ToDecimal(myArray[1]);
            var expected = 3.14159m;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AdjustCupMeasurementToTablespoons()
        {
            var adjust = new ConvertCandtToTablespoons();
            var actual = adjust.ConvertCupsToTablespoons("4.5 cups flour");
            var expected = "72.00 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        //[Test]
        //public void TestingMoreDecimals()
        //{
        //    var round = new RoundDecimalPlaces();
        //    var actual = round.RoundToHundrethDecimalPlace(150.40m);
        //    var expected = "150.4";
        //    Assert.AreEqual(expected, actual); 
        //}
        //[Test]
        //public void RoundingTablespoonsTest()
        //{
        //    var adjust = new ConvertCandtToTablespoons(); 
        //    var actual = adjust.RoundTablespoonMeasurement("1 tablespoons");
        //    var expected = "1 tablespoon";
        //    Assert.AreEqual(expected, actual); 
        //}
        //[Test]
        //public void RoundingTablespoonsTest2()
        //{
        //    var adjust = new ConvertCandtToTablespoons(); 
        //    var actual = adjust.RoundTablespoonMeasurement("12 tablespoons");
        //    var expected = "12 tablespoons";
        //    Assert.AreEqual(expected, actual); 
        //}
        [Test]
        public void AdjustTeaspoonsMeasurementToTablespoons()
        {
            var adjust = new ConvertCandtToTablespoons();
            var actual = adjust.ConvertTeaspoonsToTablespoons("5 teaspoons of something else");
            var expected = "1.67 tablespoons";
            Assert.AreEqual(expected, actual); 
        }
    }
}

