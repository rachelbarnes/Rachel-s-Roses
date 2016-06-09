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
            var CtT = new ConvertIngredientMeasurementToTablespoons();
            var line = "1 cup sugar";
            var actual = CtT.ConvertIngredientWCupMeasurementToTablespoons(line);
            var expected = "16 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFromCupsToTablespoonsTestDecimalPlaces()
        {
            var CtT = new ConvertIngredientMeasurementToTablespoons();
            var line = ".5 cups baking cocoa";
            var actual = CtT.ConvertIngredientWCupMeasurementToTablespoons(line);
            var expected = "8 tablespoons";
            Assert.AreEqual(expected, actual);
            //something is incorrect with my decimal places, hence the 2 extra chars
        }
        [Test]
        public void ConvertFromCupsToTablespoonsTestDecimalPlaces2()
        {
            var CtT = new ConvertIngredientMeasurementToTablespoons();
            var line = ".25 cups baking cocoa";
            var actual = CtT.ConvertIngredientWCupMeasurementToTablespoons(line);
            var expected = "4 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFromCupsToTablespoonsTestDecimalPlaces3()
        {
            var CtT = new ConvertIngredientMeasurementToTablespoons();
            var line = ".125 cups baking cocoa";
            var actual = CtT.ConvertIngredientWCupMeasurementToTablespoons(line);
            var expected = "2 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        //it's actually taking the amount of decimal places that originates with the starting cup size.... interesting. How do I fix this? 
         [Test]
        public void ConvertFromttoT()
        {
            var CtT = new ConvertIngredientMeasurementToTablespoons();
            var line = "3 teaspoons baking powder";
            var actual = CtT.ConvertIngredientWTeaspoonsMeasurementToTablespoons(line);
            var expected = "1 tablespoon";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void convertfromtToT2()
        {
            var c2t = new ConvertIngredientMeasurementToTablespoons();
            var line = "2 teapsoons baking soda";
            var actual = c2t.ConvertIngredientWTeaspoonsMeasurementToTablespoons(line);
            var expected = "0.67 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFromtToT3()
        {
            var c2t = new ConvertIngredientMeasurementToTablespoons();
            var line = ".5 teaspoons salt";
            var actual = c2t.ConvertIngredientWTeaspoonsMeasurementToTablespoons(line);
            var expected = "0.17 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Tablespoons()
        {
            var c2t = new ConvertIngredientMeasurementToTablespoons();
            var line = "4.333 tablespoons";
            var actual = c2t.RoundTablespoonMeasurement(line);
            var expected = "4.33 tablespoons";
            Assert.AreEqual(expected, actual);
        }
        //when the time comes, we can do tablespoons to cups, but for adjusting the recipe based off of hte multiplier, we can do tablespoons. 

       [Test]
       public void TestingFunctionalityOfConversionToDecimalAfterStringSplit()
        {
            var ConvertMeasurement = new ConvertIngredientMeasurementToTablespoons();
            var myArray = new string[] { "1", "3" };
            var actual = Convert.ToDecimal(myArray[1]);
            var expected = 3m;  
            Assert.AreEqual(expected, actual); 
        }

       [Test]
        public void ConvertRecipeToTablespoons()
        {
            var adjust = new AdjustRecipe();
            var filename = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\Rachel-s-Roses\CompilingTest.txt";
            var actual = adjust.AdjustRecipeTablespoonMeasurements(filename, 1);
            var MyRecipe = new string[] { "16 tablespoons", "5.33 tablespoons", ".66 tablespoons", "3 tablespoons", "1.33 tablespoons", "1 tablespoon" };
            Assert.AreEqual(MyRecipe, actual); 
        }
        [Test]
        public void ConvertRecipeToTablespoonsIntMultiplier()
        {
            var adjust = new AdjustRecipe();
            var filename = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\Rachel-s-Roses\CompilingTest.txt";
            var actual = adjust.AdjustRecipeTablespoonMeasurements(filename, 3);
            var MyRecipe = new string[] { "48 tablespoons", "16 tablespoons", "2 tablespoons", "9 tablespoons", "3.99 tablespoons", "3 tablespoons" };
            Assert.AreEqual(MyRecipe, actual); 
        }
        [Test]
        public void ConvertRecipeToTalbespoonDecMultiplier()
        {
           var adjust = new AdjustRecipe();
            var filename = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\Rachel-s-Roses\CompilingTest.txt";
            var actual = adjust.AdjustRecipeTablespoonMeasurements(filename, .5m);
            var MyRecipe = new string[] { "8 tablespoons", ".17 tablespoons", ".33 tablespoons", "1.5 tablespoons", ".66 tablespoons", ".5 tablespoon" };
            Assert.AreEqual(MyRecipe, actual); 
        }
        }

    }

