using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class IngredientConversion
    {
        //this method takes the lines that are in a file and converts everything measurable to tablespoons. I chose tablespoons because it is a decent middle point, rather than having 48 teaspoons to be dealing with and .208 teaspoons for cups. 
        //there are 16 tablespoons in 1 cup, and 3 teaspoons in one tablespoon, so it can allow us work with more even numbers. 
        public List<string> ConvertToTablespoons(string filename)
        {
            var decimalPlaces = new DecimalPlaces(); 
            var ReadMyFile = new Reader();
            var MyFile = ReadMyFile.ReadFile(filename);
            var Ingredient = new string[] { };
            var IngredientMeasurement = "0";
            var Recipe = new List<string>(); 
            var toTablespoons = new ConvertToTablespoons();
            foreach (var line in MyFile)
            {
                line.Split(' ');
                if (line.Contains("cup"))
                {
                    IngredientMeasurement = toTablespoons.CupsToTablespoons(Convert.ToDecimal(line[0].ToString())).ToString();
                    Console.WriteLine(decimalPlaces.HundrethDecimalPlaces(Convert.ToDecimal(IngredientMeasurement)) + " tablespoons");
                }
                if (line.Contains("tablespoon"))
                {
                    IngredientMeasurement = Int32.Parse(line[0].ToString()).ToString();
                    Console.WriteLine(decimalPlaces.HundrethDecimalPlaces(Convert.ToDecimal(IngredientMeasurement)) + " tablespoons");
                }
                if (line.Contains("teaspoon"))
                {
                    IngredientMeasurement = toTablespoons.TeaspoonsToTablespoons(Convert.ToDecimal(line[0].ToString())).ToString();
                    Console.WriteLine(decimalPlaces.HundrethDecimalPlaces(Convert.ToDecimal(IngredientMeasurement)) + " tablespoons");
                }
                Recipe.Add(IngredientMeasurement); 
            }
            return Recipe; 
        }

    }
}
