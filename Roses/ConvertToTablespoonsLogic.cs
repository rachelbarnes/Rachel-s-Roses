using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class ConvertToTablespoons
    {
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
