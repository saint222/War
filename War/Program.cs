using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
   public class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("FighterNames.txt");
            string line = "";
            while (line != null)
            {
                line = myReader.ReadLine();                
                Console.WriteLine(line);                
            }
            myReader.Close();
            Console.ReadLine();
        }
    }
}
