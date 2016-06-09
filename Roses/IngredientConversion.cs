using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class IngredientConversion
    {
        public List<string> GetIngredientMeasurement(string filename)
        {
            var DecimalPlaces = new RoundDecimalPlaces();
            var ReadMyFile = new Reader();
            var ConvertToTablespoons = new ConvertToTablespoons();
            var Ingredient = new string[] { };
            var IngredientMeasurement = "0";
            var MyFile = ReadMyFile.ReadFile(filename);
            var RecipeWithoutMeasurementUnits = new List<string>();
            var RoundedIngredientMeasurement = "";
            foreach (var line in MyFile)
            {
                Ingredient = line.Split(' '); //Ingredient is the array that is returned from the string split
                if (line.Contains("cup"))
                {
                    IngredientMeasurement = ConvertToTablespoons.CupsToTablespoons(Convert.ToDecimal(Ingredient[0])).ToString();
                    Console.WriteLine(IngredientMeasurement);
                }
                if (line.Contains("tablespoon"))
                {
                    IngredientMeasurement = Int32.Parse(Ingredient[0].ToString()).ToString();
                    Console.WriteLine(IngredientMeasurement);
                }
                if (line.Contains("teaspoon"))
                {
                    IngredientMeasurement = ConvertToTablespoons.TeaspoonsToTablespoons(Convert.ToDecimal(Ingredient[0])).ToString();
                    Console.WriteLine(IngredientMeasurement);
                }
                if (!line.Contains("cup") || line.Contains("tablespoon") || line.Contains("teaspoon"))
                {
                    IngredientMeasurement = Ingredient[0].ToString();
                    Console.WriteLine(IngredientMeasurement);
                }
                RoundedIngredientMeasurement = DecimalPlaces.RoundToHundrethDecimalPlace(Convert.ToDecimal(IngredientMeasurement));
                RecipeWithoutMeasurementUnits.Add(RoundedIngredientMeasurement);
            }
            return RecipeWithoutMeasurementUnits;
        }
    }
}
