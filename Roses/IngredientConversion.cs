using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class IngredientConversion
    {
        public void EvaluateSplitStrings(string filename)
        {
            var ReadMyFile = new Reader();
            var MyFile = ReadMyFile.ReadFile(filename);
            var Ingredient = new string[] { }; 
            var IngredientMeasurement = 0;
            var convert = new Convert();
            //foreach (var line in MyFile)
            //{
            //    Ingredient = line.Split(' ');
            //    if (line.Contains("cup"))
            //    {
            //        IngredientMeasurement = (Int32.Parse(line[0].ToString())); 
            //    }
            //}
            foreach (var line in MyFile)
            {
                line.Split(' ');
                if (line.Contains("cup"))
                {
                    IngredientMeasurement = convert.CupsToTablespoons(Int32.Parse(line[0].ToString()));
                    Console.WriteLine(IngredientMeasurement); 
                }
                if (line.Contains("tablespoon"))
                {
                    IngredientMeasurement = Int32.Parse(line[0].ToString());
                    Console.WriteLine(IngredientMeasurement); 
                }
                if (line.Contains("teaspoon"))
                {
                    IngredientMeasurement = convert.TeaspoonsToTablespoons(Int32.Parse(line[0].ToString()));
                    Console.WriteLine(IngredientMeasurement); 
                }
                else
                {
                    try
                    {
                    IngredientMeasurement = Int32.Parse(line[0].ToString());
                    Console.WriteLine(IngredientMeasurement); 
                    }
                    catch
                    {
                     (Exception e)
                    }
                }
            }
        }
    }
}