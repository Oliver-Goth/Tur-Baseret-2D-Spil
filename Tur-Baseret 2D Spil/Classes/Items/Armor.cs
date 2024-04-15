
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Damage;
using static System.Net.Mime.MediaTypeNames;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    // Abstract class representing armor in the game.
    public abstract class Armor : WearableItem
    {
        // Define a property named DamageReduction of type DamageReduction to hold information about how much damage this armor reduces.
        public DamageReduction DamageReduction { get; set; }

        // Constructor for the Armor class, which takes parameters to initialize its properties.
        public Armor(string name, int durability, string description, DamageReduction damageReduction) : base(name, 100, 1, description)
        {
            // Initialize the DamageReduction property of the armor with the provided damage reduction value.
            DamageReduction = damageReduction;
        }
    }
}
