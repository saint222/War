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
            List <string> warriorNames = new List <string> ();
            StreamReader myReader = new StreamReader("FighterNames.txt");
            string line = "";
            while (line != null)
            {
                line = myReader.ReadLine();
                warriorNames.Add(line);
            }           

            Random randomValue = new Random();

            List<Warrior> Warriors = new List<Warrior>();
            Random randomNames = new Random();
            for (int i = 0; i < 10; i++)
            {                
                int index = randomNames.Next(warriorNames.Count);
                string name = warriorNames[index];
                Warrior warrior = new Warrior(name, 5, 10, 15, randomValue);
                Warriors.Add(warrior);
            }
           
            
            //Warriors.ForEach(Console.WriteLine);


            Console.ReadLine();
        }
    }
}
