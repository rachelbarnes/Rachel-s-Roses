using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roses
{
    public class Reader
    {
        public void OpenFile(string filename)
        {
            try
            {
                if (File.Exists(filename) == true)
                    File.Open(filename, FileMode.Open);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }

        public List<string> ReadFile(string filename)
        {
            string lineOfText = "";
            var TextLines = new List<string>();
            using (StreamReader ReadMyFile = new StreamReader(filename))
            {
                while ((lineOfText = ReadMyFile.ReadLine()) != null)
                {
                    if (lineOfText.Contains("Instruction"))
                    {
                        break;
                    }
                    TextLines.Add(lineOfText);
                }
            }
            return TextLines; 
        }
    }
}
