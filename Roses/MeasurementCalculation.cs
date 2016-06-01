using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class AdjustMeasurements
    {
        public List<string> AdjustIngredientMeasurements(string filename, decimal multiplier)
        {
            var convert = new IngredientConversion();
            var GetPercent = new Percent(); 
            var ReadMyFile = new Reader();
            var AdjustRecipe = new MultiplyRecipe(); 
            var MyFile = ReadMyFile.ReadFile(filename);
            var Recipe = convert.GetIngredientMeasurement(filename);
            var AdjustedRecipe = new List<string>();
            var IngredientMeasurement = new string[]{ };
            var AdjustedIngredientMeasurement = "0"; 
            foreach (var ingredient in Recipe)
            {
                //there's something wrong with either casting or the string is in the wrong format. 
                IngredientMeasurement = ingredient.Split(' ');
                AdjustedIngredientMeasurement = AdjustRecipe.MultiplyIgredientBy((Convert.ToDecimal(IngredientMeasurement[0])), (decimal)multiplier).ToString();
                Console.WriteLine(AdjustedIngredientMeasurement + "tablespoons");
                AdjustedRecipe.Add(AdjustedIngredientMeasurement); 
            }
            return AdjustedRecipe; 
        }
    }
}
