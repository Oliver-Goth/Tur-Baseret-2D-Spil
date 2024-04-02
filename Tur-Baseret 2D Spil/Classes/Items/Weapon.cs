using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    // Klasse til at repræsentere et våben, der nedarver fra Item
    internal class Weapon : WearableItem
    {
        public int Damage { get; set; }
        public int Range { get; set; }

        //Constructor
        public Weapon(string name, int damage, int durability, int range, string description) : base(name, 100, 2, description)
        {
            Name = name;
            Damage = damage;
            Durability = durability;
            Range = range;
        }

        public override string ToString()
        {
            return $"[*****************Weapon: {Name}*****************]" + "/n" +
                   $"[**   Name              is     {Name}          **]" + "/n" +
                   $"[**   Damage            is     {Damage}        **]" + "/n" +
                   $"[**   Durability        is     {Durability}    **]" + "/n" +
                   $"[**   Range             is     {Range}         **]" + "/n" +
                   $"[**   Describtion              {Description}   **]" + "/n" +
                   $"[************************************************]";
        }
    }
}
