using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Damage
{
    // Define a class named Damage to represent the amount of damage inflicted.
    public class Damage
    {
        // Define a property named DamageAmount to store the amount of damage.
        // The set accessor is private, meaning the property can only be set within this class.
        public double DamageAmount { get; private set; }

        // Constructor for the Damage class, which initializes the DamageAmount property.
        public Damage(double dmg)
        {
            // Check if the provided damage value is less than 0.
            if (dmg < 0)
            {
                // If the damage value is negative, throw an ArgumentException with a specific error message.
                throw new ArgumentException("Damage must not be below 0");
            }

            // If the damage value is valid, assign it to the DamageAmount property.
            DamageAmount = dmg;
        }
    }
}
