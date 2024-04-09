
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Damage;
using static System.Net.Mime.MediaTypeNames;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    // Klasse til at repræsentere en rustning, der nedarver fra Item
    public abstract class Armor : WearableItem
    {
        public int Defence { get; set; }
        public DamageReduction DamageReduction { get; set; }

        //Constructor
        public Armor(string name, int durability, string description, DamageReduction damageReduction) : base(name, 100, 1, description)
        {
            DamageReduction = damageReduction;
        }

        public override string ToString()
        {
            return $"[******************Armor: {Name}*****************]" + "/n" +
                   $"[** Name                is     {Name}          **]" + "/n" +
                   $"[** Defence             is     {Defence}       **]" + "/n" +
                   $"[** Durability          is     {Durability}    **]" + "/n" +
                   $"[** Describtion                {Description}   **]" + "/n" +
                   $"[************************************************]";
        }
    }
}
