using System;
using System.IO; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class Program
    {
        static void Main(string[] args)
        {
            var GetIngredientData = new GetIngredientResponse(); 
            try
            {
                GetIngredientData.FindAndPrint("flour", "10 lb", 160);
                GetIngredientData.FindAndPrint("yeast", "4 oz", 4);
                Console.ReadLine(); 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read(); 
            }
        }
    }
}
