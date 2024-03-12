using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    // Klasse til at repræsentere et våben, der nedarver fra Item
    internal class Weapon : WearableItem
    {
        public int Damage { get; set; }
        public int Range { get; set; }

        //Constructor
        public Weapon(string name, int damage, int durability, int range, string description) : base(name, 100, 1,description)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Range = range;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Damage: {Damage}, Durability: {Durability},  Range: {Range}";
        }
    }
}
