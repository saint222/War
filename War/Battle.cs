using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Battle
    {
        Group russia = new Group() { Name = "Russia", Squads = new List<Squad>() };        
        Group usa = new Group() { Name = "USA", Squads = new List<Squad>() };      



        Squad russianSquad_1 = new Squad() { Name = "russianVodkaLovers", Warriors = new List<Warrior>() };
        Squad russianSquad_2 = new Squad() { Name = "russianBeerLovers", Warriors = new List<Warrior>() };


        Squad usaSquad_1 = new Squad() { Name = "americanVegans", Warriors = new List<Warrior>() };
        Squad usaSquad_2 = new Squad() { Name = "americanHomosexuals", Warriors = new List<Warrior>() };
          
       

    }
}
