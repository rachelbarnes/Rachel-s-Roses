using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class AdjustRecipe
    {
        public Func<decimal, decimal, decimal> AdjustSingleIngredient = (IngredientMeasurement, multiplier) => IngredientMeasurement * multiplier; 

        public string[] AdjustRecipeTablespoonMeasurements(string filename, decimal multiplier)
        {
            var ConvertMeasurements = new ConvertCandtToTablespoons(); 
            var ReadMyFile = new Reader();
            var MyFile = ReadMyFile.ReadFile(filename);
            var MyRecipe = new List<string>();
            var IngredientMeasurement = "";
            foreach (var ingredient in MyFile)
            {
                if (ingredient.Contains("cup")){
                    IngredientMeasurement = ConvertMeasurements.ConvertCupsToTablespoons(ingredient); 
                }
                if (ingredient.Contains("tablespoon"))
                {
                    IngredientMeasurement = ConvertMeasurements.RoundTablespoonMeasurement(ingredient); 
                }
                if (ingredient.Contains("teaspoon"))
                {
                    IngredientMeasurement = ConvertMeasurements.ConvertTeaspoonsToTablespoons(ingredient); 
                }
                MyRecipe.Add(IngredientMeasurement); 
            }
            return MyRecipe.ToArray(); 
        }
    }
}
