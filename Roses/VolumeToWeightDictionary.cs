using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class VolumeToWeightDictionary
    {
        //key: weight of 1 cup of the ingredient 
        //value: how many ounces said ingredient's 1 cup
        public Dictionary<string, decimal> IngredientVolumeToWeightRatio = new Dictionary<string, decimal>()
        {
            //dry ingredients
            {"flour", 5m },
            {"bread flour", 5.5m },
            {"cake flour", 4.5m },
            {"pastry flour", 4.25m },
            {"whole wheat flour", 5m },
            {"coarse cornmeal", 4.85m },
            {"fine cornmeal", 6.3m },
            {"sugar, grandulated", 7.1m } ,
            {"sugar, brown", 7.75m } ,
            {"sugar, powdered, sifted", 3.6m } ,
            {"sugar, powdered, unsifted", 4.4m },
            {"milk powder", 4.4m },
            {"cocoa powder", 4.16m },
            {"baking soda", 8.57m },
            {"baking powder", 8.4m },
            {"salt", 11.49m },
            {"general spices", 4.4m },
            {"yeast, active dry", 5.49m },
            {"vegetable oil", 7.7m },

            //wet ingredientsWeightOf1CupIngredient
            {"butter", 8m },
            {"milk", 8m },
            {"buttermilk", 8.5m },
            {"heavy cream", 8.4m },
            {"cream cheese", 8.2m },
            {"sour cream", 8.6m },
            {"egg", 1.7m },
            {"egg yolk", .7m },
            {"yogurt", 8.6m },
            {"shortening", 7.25m } ,
            {"honey", 12m } ,
            {"vegetable oil", 7.7m } ,
            {"vanilla extract", 6.86m } ,
            
            //fruits, nuts and chocolate chips
            {"raisins", 5m },
            {"coconut, dry shredded", 2.5m },
            {"oats", 3m },
            {"chocolate chips", 5.35m },
            {"walnuts, chopped", 4.3m },
            {"walnuts, halved", 3.5m },
            {"pecans, halved", 3.5m },
            {"bananas",  12m },//about 1 1/3 cups mashed bananas = 1 lb
            {"zucchini", 8m }
};
    }
}
