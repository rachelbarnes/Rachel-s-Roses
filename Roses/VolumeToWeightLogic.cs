using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class VolumeToWeightLogic
    {
        public Func<string, string, string> ConcatRatioArray => (IngredientName, Weight) => IngredientName + " : " + Weight;

        public List<string> ReadRatiosFromRatioDatabase(string filename)
        {
            var read = new Reader();
            var splitRatio = new SplitLines();
            var MyRatioDatabase = read.ReadDatabase(filename);
            var ArrayRatioDatabase = new List<string>();
            foreach (var ratio in MyRatioDatabase)
            {
                ArrayRatioDatabase.Add(ratio); 
                //ArrayRatioDatabase.Add(splitRatio.SplitLineAtColon(ratio));
            }
            return ArrayRatioDatabase;
        }

        public string ReadIngredientRatio(string Ingredient, string filename)
        {
            var vw = new VolumeToWeightLogic();
            var ListOfRatios = vw.ReadRatiosFromRatioDatabase(filename);
            var currentIngredient = ""; // new string[] { }; 
            for (int line = 0; line < ListOfRatios.Count; line++)
            {
                if(ListOfRatios[line].Contains(Ingredient))
                {
                    currentIngredient = ListOfRatios[line]; 
                }
            }
            return currentIngredient; 
        }

        //public List<string> GetAllIngredientNamesFromRatioDatabase(string filename)
        //{
        //    var vw = new VolumeToWeightLogic();
        //    var ListOfRatios = vw.ReadRatiosFromRatioDatabase(filename);
        //    foreach (var ratio in ListOfRatios)
        //    {
                
        //    }
        //    var CompiledListIngredients = new List<string>(); 
            
        //}

        public decimal ReadOuncesForIngredient(string Ingredient, string filename)
        {
            var vw = new VolumeToWeightLogic();
            var split = new SplitLines(); 
            var currentIngredient = split.SplitLineAtColon(vw.ReadIngredientRatio(Ingredient, filename));
            return Convert.ToDecimal(currentIngredient[1]); 
        }

        public decimal PercentageOfMeasuredCupsToStandardCups(string measuredCups)
        {
            var divide = new GeneralFunctionality(); 
            if (measuredCups.Contains('/'))
            {
                return divide.CalculateDecimalFromFraction(measuredCups); 
            }
            else
            {
                return ((Convert.ToDecimal(measuredCups)) / 1); 
            }
        }
        public decimal GetAmountOfOuncesUsed(string Ingredient, string measuredCups, string filename)
        {
            var vw = new VolumeToWeightLogic();
            var divide = new GeneralFunctionality();
            var GetOuncesForIngredient = vw.ReadOuncesForIngredient(Ingredient, filename); 
            var GetPercentMeasuredCupsToStandardCups = vw.PercentageOfMeasuredCupsToStandardCups(measuredCups);
            return GetPercentMeasuredCupsToStandardCups * GetOuncesForIngredient; 
        }
    }
} 
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
//            //
//        public string ConvertReadMeasuredOuncesToCups(string IngredientName, decimal MeasuredOunces, string filename)
//        {
//            var SplitRatioData = new SplitLines(); 
//            var ListOfRatios = SplitRatioData.SplitVolumeToWeightDatabaseLines(filename);
//            var RatioedOunces = 0m;
//            var CalculatedCups = 0m;
//            var MeasuredIngredientInCups = "";
//            for (int Line = 0; Line < ListOfRatios.Count; Line++)
//            {
//                if (ListOfRatios[Line].Contains(IngredientName))
//                {
//                    RatioedOunces = GetOuncesFromVolumeWeightRatio(filename);
//                    CalculatedCups = MeasuredOunces / RatioedOunces;
//                    MeasuredIngredientInCups = ConcatRatioArray(IngredientName, CalculatedCups.ToString());
//                }
//            }
//            return MeasuredIngredientInCups + " cups";
//        }

//        //this gets the number ounces from the MeasuredCups for a specified Ingredient as the parameter in the file specified and gives back the array. 
//        public decimal ConvertReadMeasuredCupsToOunces(string IngredientName, decimal MeasuredCups, string filename)
//        {
//            var SplitRatioData = new SplitLines(); 
//            var ListOfRatios =SplitRatioData.SplitVolumeToWeightDatabaseLines(filename);
//            var RatioedOunces = 0m;
//            var CalculatedOunces = 0m;
//            var ConvertReadMeasuredIngredientInOunces = "";
//            for (int Line = 0; Line < ListOfRatios.Count; Line++)
//            {
//                if (ListOfRatios[Line].Contains(IngredientName))
//                {
//                    RatioedOunces = GetOuncesFromVolumeWeightRatio(filename);
//                    //this is the filename of the file that contains the ratios of the 1 cup measured ingredient : ounces - need to look at this to see if this will impact any of my designs.  
//                    CalculatedOunces = MeasuredCups * RatioedOunces;
//                    //ConvertReadMeasuredIngredientInOunces = ConcatRatioArray(IngredientName, CalculatedOunces.ToString()); 
//                }
//            }
//            return Convert.ToDecimal(ConvertReadMeasuredIngredientInOunces); // + " ounces"; 
//        }

//        public decimal GetOuncesFromRatio(string IngredientName, decimal MeasuredCups, string filename)
//        {
//            var SplitRatioData = new SplitLines(); 
//            var ListOfRatios =SplitRatioData.SplitVolumeToWeightDatabaseLines(filename);
//            var RatioedOunces = 0m;
//            var CalculatedOunces = 0m;
//            for (int Line = 0; Line < ListOfRatios.Count; Line++)
//            {
//                if (ListOfRatios[Line].Contains(IngredientName))
//                {
//                    RatioedOunces = GetOuncesFromVolumeWeightRatio(filename);
//                    CalculatedOunces = MeasuredCups * RatioedOunces;
//                }
//            }
//            return CalculatedOunces; 
//        }
        
//        //get the ounces from the IngredientVolume : Weight Ratio in decimal form
//        public decimal GetOuncesFromVolumeWeightRatio(string filename)
//        {
//            var SplitRatioData = new SplitLines(); 
//            var ListOfRatioArrays = SplitRatioData.SplitVolumeToWeightDatabaseLines(filename);
//            var IngredientName = "";
//            var WeightInOunces = "";
//            var ListOfRatios = new List<string[]>();
//            foreach (string[] ratio in ListOfRatioArrays)
//            {
//                IngredientName = ratio[0];
//                WeightInOunces = ratio[1];
//            }
//            return Convert.ToDecimal(WeightInOunces);
//        }
//    }
//}
////looking at making an ingredient factory for costs: 
////create a draw method on an interface
////create class that implement that interface
////create a factory that generates objects of those classes given specific/required information
////use the factory to get objects from those by then passing "an information such as type", so basically using an interface as a type
////for future reference to these specific notes: http://www.tutorialspoint.com/design_pattern/factory_pattern.htm and it provides a good but brief explanation of what's going on as well as exmaple code with the interface and and with classes. 

////IngredientFactory Purpose: 
