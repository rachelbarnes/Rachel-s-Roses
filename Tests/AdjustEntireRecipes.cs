using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Roses
{
    [TestFixture]
    public class AdjustWholeRecipesTests
    {
        [Test]
        public void ConvertRecipeToTablespoons()
        {
            var adjust = new AdjustRecipe();
            var filename = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\Rachel-s-Roses\CompilingTest.txt";
            var actual = adjust.AdjustRecipeTablespoonMeasurements(filename, 1);
            var MyRecipe = new string[] { "16.00 tablespoons", "5.33 tablespoons", ".67 tablespoons", "3.00 tablespoons", "1.33 tablespoons", "1.00 tablespoon" };
            Assert.AreEqual(MyRecipe, actual.ToList());
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
