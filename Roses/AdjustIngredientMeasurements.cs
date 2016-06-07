using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class AdjustIngredientMeasurement
    {   //purpose is to adjust the values based on the given multiplier
        public Func<decimal, decimal, decimal> AdjustIngredient = (ingredientMeasurement, multiplier) => (ingredientMeasurement * multiplier);
    }
    public class AdjustMeasurements
    {
        public List<string> AdjustIngredientMeasurements(string filename, decimal multiplier)
        {
            var convertIngredientMeasurementsToTablespoons= new IngredientConversion();
            var MyRecipe = convertIngredientMeasurementsToTablespoons.GetIngredientMeasurement(filename);
            var AdjustedIngredient = 0m;
            var AdjustedRecipe = new List<string>(); 
            foreach (var line in MyRecipe)
            {
                AdjustedIngredient = Convert.ToDecimal(line) * multiplier;
                if (AdjustedIngredient == 1m)
                {
                    AdjustedRecipe.Add(AdjustedIngredient + " tablespoon");
                }
   
                else
                {
                    AdjustedRecipe.Add(AdjustedIngredient + " tablespoons");
                }
            }
            Console.WriteLine(AdjustedRecipe); 
            return AdjustedRecipe;
        }
    }
}
            //trial and error
            //var convert = new IngredientConversion();
            //var GetPercent = new Percent();
            //var ReadMyFile = new Reader();
            //var AdjustRecipe = new AdjustIngredientMeasurement();
            //var MyFile = ReadMyFile.ReadFile(filename);
            //var Recipe = convert.GetIngredientMeasurement(filename);
            //var AdjustedRecipe = new List<string>();
            //var IngredientMeasurement = new string[] { };
            //var AdjustedIngredientMeasurement = 0m;
            //var AdjustedIngredient = "";

            //this method takes the tablespoon conveted ingredient meaurements and adjusts it based on a multiplier
            //foreach (var ingredient in Recipe)
            //{
            //    IngredientMeasurement = ingredient.Split(' ');
            //    input string isn't in the correct format
            //    try
            //    {
            //        AdjustedIngredientMeasurement = AdjustRecipe.AdjustIngredient(Convert.ToDecimal(IngredientMeasurement[0]), multiplier);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("There was an error interpreting this ingredient");
            //        Console.WriteLine(ex);
            //        Console.ReadLine();
            //        i dont think it's taking the eggs well
            //    }
            //    if (AdjustedIngredientMeasurement == 1)
            //    {
            //        AdjustedIngredient = AdjustedIngredientMeasurement.ToString() + " tablespoon";
            //    }
            //    else
            //    {
            //        AdjustedIngredient = AdjustedIngredientMeasurement.ToString() + " tablespoons";
            //    }
            //    Console.WriteLine(AdjustedIngredient);
            //    AdjustedRecipe.Add(AdjustedIngredient);
            //}
