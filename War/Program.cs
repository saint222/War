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
            //StreamReader myReader = new StreamReader("FighterNames.txt");
            //string line = "";
            //while (line != null)
            //{
            //    line = myReader.ReadLine();                
            //    Console.WriteLine(line);                
            //}
            //myReader.Close();

            Random randomValue = new Random();
            Warrior warrior_1 = new Warrior ("Petrov", 5, 10, 15, randomValue );
            Console.WriteLine($"Warrior {warrior_1.Name} with the health value = {warrior_1.Health}, attack value = {warrior_1.Attack} and power value = {warrior_1.Power}.");
            Console.ReadLine();
        }
    }
}
