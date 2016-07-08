using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class GeneralFunctionality
    {
        public Func<int, int> sqaure = x => x * x;

        public Func<double, double, int> percent = (x, y) => (int)((x / y) * 100);

        public decimal CupsToTablespoons(decimal cups)
        {
            return cups * 16;
        }
        public decimal TeaspoonsToTablespoons(decimal teaspoons)
        {
            return teaspoons / 3;
        }
    }
}

