using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    // Klasse til at repræsentere en creatures
    abstract class Creature
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        //Constructor
        public Creature(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Health: {Health}, Level: {Level}";
        }
    }
}