using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Group
    {
        public string Name { get; set; }
        public List<Squad> Squads { get; set; }


        public void AboutSquads()
        {

            for (int i = 0; i < Squads.Count; i++)
                for (int j = 0; j < Squads[i].Warriors.Count; j++)
                {
                    
                    Console.WriteLine($"{Squads[i].Warriors[j].Name};");
                    Console.WriteLine($" {Squads[i].Warriors[j].Attack};");
                    Console.WriteLine($" {Squads[i].Warriors[j].Health};");
                    Console.WriteLine($" {Squads[i].Warriors[j].Power};");
                }
        }
        
    }


}
