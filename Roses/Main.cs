using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader();
            var convert = new IngredientConversion();
            var adjust = new AdjustMeasurements(); 
            var filename = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\Rachel-s-Roses\test.txt";

            //convert.PrintRecipe(filename);
            Console.WriteLine(adjust.AdjustIngredientMeasurements(filename, 2)); 
            Console.ReadLine();

            //adjust.AdjustIngredientMeasurements(filename, .25m); 
        }
    }
}
