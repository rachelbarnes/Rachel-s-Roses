using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class SqaureFN
    {
        public Func<int, int> sqaure = x => x * x;
    }
    public class Percent
    {
        public Func<double, double, int> percent = (x, y) => (int)((x / y) * 100);
    }
    public class MultiplyRecipe
    {
        public Func<decimal, decimal, decimal> MultiplyIgredientBy = (ingredientMeasurement, multiplier) => (ingredientMeasurement * multiplier); 
    }
}
