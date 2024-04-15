using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    // Abstract class representing weapon in the game.
    public abstract class Weapon : WearableItem
    {
        // Define a property named DamageReduction to hold information about how much damage this armor reduces.
        public Damage.Damage DamageGive { get; private set; }

        // Constructor for the weapon class, which takes parameters to initialize its properties.
        public Weapon(string name, double durability, string type, string description, Damage.Damage damage) : base(name, durability, type, description)
        {
            // Initialize the Damageproperty of the weapon with the provided damage value.
            DamageGive = damage;
        }
    }
}
