using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class DataManager
    {
        public string IngredientName;
        public string IngredientPrice;
        public static Dictionary<string, string> IngredientNamePriceDictionary = new Dictionary<string, string>(); 

        public void GetDeserializedDatabaseData(string ResponseDatabaseFilename)
        {
            var read = new Reader();
            var split = new SplitLines(); 
            var ResponseDatabase = read.ReadDatabase(ResponseDatabaseFilename);
            var LineSplit = new string[] { }; 
            foreach (var line in ResponseDatabase)
            {
                if (line.Count(x => x == ':') > 4)
                {
                    LineSplit = split.SplitLineAtColon(line);
                    IngredientName = LineSplit[1];
                    IngredientPrice = split.SplitLineAtSpecifiedCharacter(LineSplit[3], '$')[1]; 
                }
                if (line.Count(x => x== ':') < 5)
                {
                    LineSplit = split.SplitLineAtColon(line);
                    IngredientName = LineSplit[0];
                    IngredientPrice = split.SplitLineAtSpecifiedCharacter(LineSplit[2], '$')[1]; 
                }
                IngredientNamePriceDictionary.Add(IngredientName, IngredientPrice); 
            }
        }
    }
}
