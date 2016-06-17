//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Roses
//{
//    public class AdjustMeasurements
//    {
//        public Func<decimal, decimal, decimal> AdjustIngredient = (ingredientMeasurement, multiplier) => (ingredientMeasurement * multiplier);

<<<<<<< HEAD
        public List<string> AdjustIngredientMeasurements(string filename, decimal multiplier)
        {
            var ConvertToTablespoonMeasurements = new IngredientConversion();
            var combine = new CombineArrays();
            var MyRecipe = ConvertToTablespoonMeasurements.GetIngredientMeasurement(filename);
            var AdjustedIngredient = 0m;
            var AdjustedRecipe = new List<string>();
            foreach (var line in MyRecipe)
            {
                AdjustedIngredient = AdjustIngredient(Convert.ToDecimal(line), multiplier);
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
=======
//        public List<string> AdjustIngredientMeasurements(string filename, decimal multiplier)
//        {
//            var convertIngredientMeasurementsToTablespoons = new IngredientConversion();
//            var combine = new CombineArrays();
//            var MyRecipe = convertIngredientMeasurementsToTablespoons.GetIngredientMeasurement(filename);
//            var AdjustedIngredient = 0m;
//            var AdjustedRecipe = new List<string>();
//            foreach (var line in MyRecipe)
//            {
//                AdjustedIngredient = AdjustIngredient(Convert.ToDecimal(line), multiplier);
//                if (AdjustedIngredient == 1m)
//                {
//                    AdjustedRecipe.Add(AdjustedIngredient + " tablespoon");
//                }
//                else
//                {
//                    AdjustedRecipe.Add(AdjustedIngredient + " tablespoons");
//                }
//            }
//            Console.WriteLine(AdjustedRecipe);
//            return AdjustedRecipe;
//        }
//    }
//}
>>>>>>> 2671aee98732731217c28257cb204a1fa6c0ff22
