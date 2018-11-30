using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Power { get; set; }

        

        public Warrior(string name, int health, int attack, int power, Random randomValue)
        {
            int randomForHealth = randomValue.Next(1, 30);
            int randomForAttack = randomValue.Next(1, 6);
            int randomForPower = randomValue.Next(0, 4);
            Name = name;            
            Health = health + 50 + randomForHealth;
            Attack = attack + 6 + randomForAttack;
            Power = power + 1 + randomForPower;
        }

    }
}
