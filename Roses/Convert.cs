using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class Convert
    {
        //PAY ATTENTION TO TYPES HERE - THE TYPES HERE AND IN THE TESTS NEED TO CHANGE
        public int CupsToTablespoons(int cups)
        {
            return cups * 16;
        }
        public int TeaspoonsToTablespoons(int teaspoons)
        {
            return teaspoons / 3;
        }
    }
}
