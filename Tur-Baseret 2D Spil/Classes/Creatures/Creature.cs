using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Classes.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.Creatures
{
    // Klasse til at repræsentere en creatures
    public abstract class Creature
    {
        public Position Position { get; protected set; }
        public List<WearableItem> Loot { get; protected set; }
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Level { get; protected set; }

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