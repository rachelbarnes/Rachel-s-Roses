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
            var convert = new ConvertToTablespoons();
            var actual = 16;
            Assert.AreEqual(convert.CupsToTablespoons(1), actual);
        }
        [Test]
        public void TestForCups()
        {
            var convert = new ConvertToTablespoons();
            var actual = 32;
            Assert.AreEqual(convert.CupsToTablespoons(2), actual);
        }
        [Test]
        public void ConvertCtoT2()
        {
            var convert = new ConvertToTablespoons();
            var actual = 8;
            Assert.AreEqual(convert.CupsToTablespoons(.5m), actual);
        }
        [Test]
        public void ConverttToT()
        {
            var convert = new ConvertToTablespoons();
            var actual = 1;
            Assert.AreEqual(convert.TeaspoonsToTablespoons(3), actual);
        }
        //[Test]
        //public void ConverttTo2()
        //{
        //    var convert = new ConvertToTablespoons();
        //    var actual = (1.66m);
        //    var expected = String.Format("{0:0.00", convert.TeaspoonsToTablespoons(5m)); 
        //    Assert.AreEqual(expected, actual);
        //}
        //[Test]
        //public void DivideRecipebyHalf()
        //{
        //    var calculate = new MeasurementCalculation();
        //    var filename = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\Rachel-s-Roses\TestForMeasurementCalculation";
        //   // var actual = calculate.IngredientMeasurementCalculator(filename); 
        //}
        [Test]
        public void AllStringsAttached()
        {
            var convert = new IngredientConversion();
            var myIngredientLine = new string[] { "1", "cup", "butter,", "melted" };
            var combinedLine = "cup butter, melted"; 
            var actual = convert.CombineArray(myIngredientLine);
            var expected = combinedLine;
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void StillStringsAttached()
        {
            var convert = new IngredientConversion();
            var myIngredientLine = new string[] { "4", "cups", "Softasilk", "flour,", "sifted", "finely" };
            var combinedLine = "cups Softasilk flour, sifted finely"; 
            var actual = convert.CombineArray(myIngredientLine);
            var expected = combinedLine;
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void LessStringsAttached()
        {
            var convert = new IngredientConversion();
            var myIngredientLine = new string[] { "4", "cups", "Gold", "Medal", "flour,", "sifted", "finely" };
            var combinedLine = "Gold Medal flour, sifted finely"; 
            var actual = convert.CombineArrayWithoutOriginalUnitofMeasurement(myIngredientLine);
            var expected = combinedLine;
            Assert.AreEqual(expected, actual); 
        }
    }
}
