using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class VolumeToWeightLogic
    {
        public Func<decimal, decimal> PoundsToOunces = Pounds => Pounds * 16;

        public Func<decimal, decimal> OuncesToPounds = Ounces => Ounces / 16;

        public Func<decimal, decimal> OuncesToGrams = Ounces => Ounces * 28;

        public Func<decimal, decimal> GramsToOunces = Grams => Grams / 28;

        public Func<decimal, decimal> GramsToPounds = Grams => (Grams / 28) / 16;

        public Func<string, string, string> ConcatRatioArray => (IngredientName, Weight) => IngredientName + " : " + Weight;

        //Read text file, and split each line at the ':'; this prints out a list of the arrays that come from the line.split(':') method. 
        public List<string[]> SplitRatioLinesIntoIngredientVolumeWeightRatios(string filename)
        {
            var ReadMyFile = new Reader();
            var SplitLine = new SplitLines();
            var RatioDatabase = ReadMyFile.ReadVolumeToWeightDatabase(filename);
            var RatioArray = new string[] { };
            var ListOfRatios = new List<string[]>();
            foreach (string ratio in RatioDatabase)
            {
                RatioArray = SplitLine.SplitLineAtColon(ratio);
                ListOfRatios.Add(RatioArray);
            }
            return ListOfRatios;
        }

        //this gets the number cups from the MeasuredOunces for a specified Ingredient as the parameter in the file specified
        public string MeasuredOuncesToCups(string IngredientName, decimal MeasuredOunces, string filename)
        {
            var ListOfRatios = SplitRatioLinesIntoIngredientVolumeWeightRatios(filename);
            var RatioedOunces = 0m;
            var CalculatedCups = 0m;
            var MeasuredIngredientInCups = "";
            for (int Line = 0; Line < ListOfRatios.Count; Line++)
            {
                if (ListOfRatios[Line].Contains(IngredientName))
                {
                    RatioedOunces = GetOuncesFromVolumeWeightRatio(filename);
                    CalculatedCups = MeasuredOunces / RatioedOunces;
                    MeasuredIngredientInCups = ConcatRatioArray(IngredientName, CalculatedCups.ToString());
                }
            }
            return MeasuredIngredientInCups + " cups";
        }

        //this gets the number ounces from the MeasuredCups for a specified Ingredient as the parameter in the file specified
        public string MeasuredCupsToOunces(string IngredientName, decimal MeasuredCups, string filename)
        {
            var ListOfRatios = SplitRatioLinesIntoIngredientVolumeWeightRatios(filename);
            var RatioedOunces = 0m;
            var CalculatedOunces = 0m;
            var MeasuredIngredientInOunces = "";
            for (int Line = 0; Line < ListOfRatios.Count; Line++)
            {
                if (ListOfRatios[Line].Contains(IngredientName))
                {
                    RatioedOunces = GetOuncesFromVolumeWeightRatio(filename);
                    //this is the filename of the file that contains the ratios of the 1 cup measured ingredient : ounces - need to look at this to see if this will impact any of my designs.  
                    CalculatedOunces = MeasuredCups * RatioedOunces;
                    MeasuredIngredientInOunces = ConcatRatioArray(IngredientName, CalculatedOunces.ToString()); 
                }
            }
            return MeasuredIngredientInOunces + " ounces"; 
        }
        //get the ounces from the IngredientVolume : Weight Ratio in decimal form
        public decimal GetOuncesFromVolumeWeightRatio(string filename)
        {
            var ListOfRatioArrays = SplitRatioLinesIntoIngredientVolumeWeightRatios(filename);
            var IngredientName = "";
            var WeightInOunces = "";
            var ListOfRatios = new List<string[]>();
            foreach (string[] ratio in ListOfRatioArrays)
            {
                IngredientName = ratio[0];
                WeightInOunces = ratio[1];
            }
            return Convert.ToDecimal(WeightInOunces);
        }
    }
}
//create a draw method on an interface
//create class that implement that interface
//create a factory that generates objects of those classes given specific/required information
//use the factory to get objects from those by then passing "an information such as type", so basically using an interface as a type
//for future reference to these specific notes: http://www.tutorialspoint.com/design_pattern/factory_pattern.htm and it provides a good but brief explanation of what's going on as well as exmaple code with the interface and and with classes. 

//IngredientFactory Purpose: 
