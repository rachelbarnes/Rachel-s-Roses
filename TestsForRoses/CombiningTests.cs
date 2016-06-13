using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework; 

namespace Roses
{
    class CombiningTests
    {  [Test]
        public void AllStringsAttached()
        {
            var combine = new CombineArrays();
            var myIngredientLine = new string[] { "1", "cup", "butter,", "melted" };
            var combinedLine = "cup butter, melted"; 
            var actual = combine.CombineArray(myIngredientLine);
            var expected = combinedLine;
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void StillStringsAttached()
        {
            var combine = new CombineArrays();
            var myIngredientLine = new string[] { "4", "cups", "Softasilk", "flour,", "sifted", "finely" };
            var combinedLine = "cups Softasilk flour, sifted finely"; 
            var actual = combine.CombineArray(myIngredientLine);
            var expected = combinedLine;
            Assert.AreEqual(expected, actual); 
        }
        [Test]
        public void LessStringsAttached()
        {
            var combine = new CombineArrays();
            var myIngredientLine = new string[] { "4", "cups", "Gold", "Medal", "flour,", "sifted", "finely" };
            var combinedLine = "Gold Medal flour, sifted finely"; 
            var actual = combine.CombineArrayWithoutOriginalUnitofMeasurement(myIngredientLine);
            var expected = combinedLine;
            Assert.AreEqual(expected, actual); 
        }
        //[Test]
        public void TestingIngredientsWithoutMeasurements()
        {
            var adjust = new AdjustRecipe();
            var myIngredientLine = "3 eggs, lightly beaten";
            var stringSplit = myIngredientLine.Split(' ');
            var actual = adjust.AdjustRecipeTablespoonMeasurements(myIngredientLine, 2);
            Assert.AreEqual(6, actual);   
        }
        [Test]
        public void TestingCombineArrays()
        {
            var combine = new CombineArrays();
            var myIngredientLine = "1/2 cup butter, melted and cooled";
            var myIngredient = myIngredientLine.Split(' '); 
            var actual = combine.CombineArrayWithStartingPoint(myIngredient, 3);
            var expected = "melted and cooled";
            Assert.AreEqual(expected, actual);  
        }
    }
}
