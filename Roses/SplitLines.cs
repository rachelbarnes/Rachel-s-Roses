using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class SplitLines
    {
        public Func<string, string[]> SplitLineAtSpace = line => line.Split(' ');
        public Func<string, char, string[]> SplitLineAtSpecifiedCharacter = (line, character) => line.Split(character);
        public Func<string, string[]> SplitLineAtColon = line => line.Split(':');

        //Read text file, and split each line at the ':'; this prints out a list of the arrays that come from the line.split(':') method. 
        public List<string[]> SplitVolumeToWeightDatabaseLines(string filename)
        {
            var ReadMyFile = new Reader();
            var RatioDatabase = ReadMyFile.ReadDatabase(filename);
            var ListOfRatios = new List<string[]>();
            var VolumeToWeightRatio = new string[] { };
            foreach (var ratio in RatioDatabase)
            {
                if (ratio.Contains(':'))
                {
                    VolumeToWeightRatio = SplitLineAtColon(ratio);
                    ListOfRatios.Add(VolumeToWeightRatio);
                }
            }
            return ListOfRatios;
        }
        public string[] ExtraColonInString(string IngredientNamePriceString)
        {
            var split = new SplitLines();
            var SplitIngredientNamePriceArray = split.SplitLineAtColon(IngredientNamePriceString);
            var NumberOfColons = IngredientNamePriceString.Count(x => x == ':');
            var IngredientName = "";
            var IngredientPrice = ""; 
            var AdjustedIngredientNamePriceArray = new string[2] {IngredientName, IngredientPrice };
            if (NumberOfColons > 3)
            {
                IngredientName = SplitIngredientNamePriceArray[1];
                IngredientPrice = SplitIngredientNamePriceArray[3];
                AdjustedIngredientNamePriceArray[0] = IngredientName;
                AdjustedIngredientNamePriceArray[1] = IngredientPrice;
            }
            return AdjustedIngredientNamePriceArray;
        }
    }
}
