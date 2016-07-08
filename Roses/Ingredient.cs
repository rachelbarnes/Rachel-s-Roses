using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class Ingredient
    {
        public string SellingWeightOfIngredientInOunces { get; set; }
        public string CostOfIndividualIngredient {get; set;}

        /*logic of my spreadsheet: 
         - determine how many cups I will need to buy of a certain ingredient, in cups preferably, based on numerous recipes, or a single recipe. 
          - determine the cost per unit sold, which there would most likely be numerous selling amounts that are offered
          - determine the selling unit's weight in ounces
           - based on the ratio of volume to weight, how many items will I need to buy based on how many cups I need, and thus how many ounces I need
           - what is the estimated cost, which is simply how many of a particular item I need to buy multiplied by the cost per unit sold
           - aggregate all the prices of all the ingredients to compose a total price for the event I'm working  */
        public void DeterminePriceByVolumeToWeightRatio(Ingredient ingredient)
        {
            
        }
    }
}
