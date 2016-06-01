using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class IngredientConversion
    {
        //this method combines a string array
        //combines a string array excluding the first split string (designed for arrays returning from split strings) 
        public string CombineArray(string[] IngredientLine)
        {
            return string.Join(" ", IngredientLine, 1, (IngredientLine.Length - 1));
        }
        //combines a string array excluding the first 2 elements (designed for arrays returning from split strings)
        //as an interesting note... when i start the index at 2, which omits the actual measurement and unit of measurement, I have to decrease the length by 2. It gives the total length, it doens't give when to stop. So when I had (IngredientLine - 1), I was asking it to go outside of the bounds of the array. 
        public string CombineArrayWithoutOriginalUnitofMeasurement(string[] IngredientLine)
        {
            var returnstring = "";
            if (IngredientLine.Count() >= 2)
            {
                returnstring = string.Join(" ", IngredientLine, 2, (IngredientLine.Length - 2));
            }
            else
            {
                returnstring = CombineArray(IngredientLine);  
            }
            return returnstring; 
        }

        //there are 16 tablespoons in 1 cup, and 3 teaspoons in one tablespoon, unfortunately this provides the most even numbers I can get doing this
        //converts everything to T; easier to use than .02 cups for teaspoons and 48 t for cups. provides middle ground, and easiest numbers to split. 
        public List<string> GetIngredientMeasurement(string filename)
        {
            var DecimalPlaces = new DecimalPlaces();
            var ReadMyFile = new Reader();
            var ConvertToTablespoons = new ConvertToTablespoons();
            var Ingredient = new string[] { };
            var IngredientMeasurement = "0";
            var MyFile = ReadMyFile.ReadFile(filename);
            var Recipe = new List<string>();

            foreach (var line in MyFile)
            {
                Ingredient = line.Split(' '); //Ingredient is the array that is returned from the string split
                if (line.Contains("cup"))
                {
                    IngredientMeasurement = ConvertToTablespoons.CupsToTablespoons(Convert.ToDecimal(Ingredient[0].ToString())).ToString();
                }
                if (line.Contains("tablespoon"))
                {
                    IngredientMeasurement = Int32.Parse(Ingredient[0].ToString()).ToString();
                }
                if (line.Contains("teaspoon"))
                {
                    IngredientMeasurement = ConvertToTablespoons.TeaspoonsToTablespoons(Convert.ToDecimal(Ingredient[0].ToString())).ToString();
                }
                if (!line.Contains("cup") || line.Contains("tablespoon") || line.Contains("teaspoon"))
                {
                    IngredientMeasurement = Ingredient[0].ToString();
                }
                Recipe.Add(IngredientMeasurement);
            }
            return Recipe;
        }
        //figure out what's going to happen with below
        //this does too much for me to be comfortable with this. 
        public List<string> PrintRecipe(string filename)
        {
            var decimalPlaces = new DecimalPlaces();
            var ConvertToTablespoons = new ConvertToTablespoons();
            var ReadMyFile = new Reader();
            var MyFile = ReadMyFile.ReadFile(filename);
            var Ingredient = new string[] { };
            var IngredientMeasurement = "0";
            var Recipe = new List<string>();
            var RestOfIngredient = "";

            foreach (var line in MyFile)
            {
                Ingredient = line.Split(' '); //Ingredient is the array that is returned from the string split
                RestOfIngredient = CombineArrayWithoutOriginalUnitofMeasurement(Ingredient);
                if (line.Contains("cup"))
                {
                    IngredientMeasurement = ConvertToTablespoons.CupsToTablespoons(Convert.ToDecimal(Ingredient[0].ToString())).ToString();
                    Console.WriteLine(decimalPlaces.HundrethDecimalPlaces(Convert.ToDecimal(IngredientMeasurement)) + " tablespoons" + RestOfIngredient);
                }
                if (line.Contains("tablespoon"))
                {
                    IngredientMeasurement = Int32.Parse(Ingredient[0].ToString()).ToString();
                    Console.WriteLine(decimalPlaces.HundrethDecimalPlaces(Convert.ToDecimal(IngredientMeasurement)) + " tablespoons" + RestOfIngredient);
                }
                if (line.Contains("teaspoon"))
                {
                    IngredientMeasurement = ConvertToTablespoons.TeaspoonsToTablespoons(Convert.ToDecimal(Ingredient[0].ToString())).ToString();
                    Console.WriteLine(decimalPlaces.HundrethDecimalPlaces(Convert.ToDecimal(IngredientMeasurement)) + " tablespoons" + RestOfIngredient);
                }
                if (!line.Contains("cup") || line.Contains("tablespoon") || line.Contains("teaspoon"))
                {
                    RestOfIngredient = CombineArray(Ingredient);
                    IngredientMeasurement = Ingredient[0].ToString();
                    Console.WriteLine(IngredientMeasurement + RestOfIngredient);
                }
                Recipe.Add(IngredientMeasurement);
            }
            return Recipe;
        }
    }
}
