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
            var reader = new Reader();
            var filename = @"C:\Users\Administrator\Documents\Visual Studio 2015\Projects\Rachel-s-Roses\test.txt";
            //reader.OpenFile(filename);

            reader.ReadFile(filename); 
            Console.ReadLine();
        }
    }
}
