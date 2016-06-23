using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class SquareANumber
    {
        public Func<int, int> sqaure = x => x * x;
        //while writing tests for this, I thought that we could actually do a class object, then when it's called, it's: 
        //var sqaure8 = new SquareANumber(8) and it should then just return 64. 
        //It just skips a step in functionality, adds more code to this class although saves code elsewhere. Just a thought. 
    }
    public class Percent
    {
        public Func<double, double, int> percent = (x, y) => (int)((x / y) * 100);
    }
    public class SplitLines
    {
        //when you rewrite the measurement calculator, use SplitLineAtSpecifiedChar()
        public string[] SplitLineAtSpaces(string line)
        {
            return line.Split(' ');
        }
        public string[] SplitLineAtColon(string line)
        {
            return line.Split(':'); 
        }
        public string[] SplitLineAtSpecifiedChar(char Character, string line)
        {
            return line.Split(Character); 
        }
    }
}
