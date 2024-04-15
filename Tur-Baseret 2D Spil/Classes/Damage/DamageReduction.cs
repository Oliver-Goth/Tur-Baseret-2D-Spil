using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.Damage
{
    // Define a class named DamageReduction to represent the amount of damage reduction applied.
    public class DamageReduction
    {
        // Define a property to store the amount of damage reduction.
        // The set accessor is private, meaning the property can only be set within this class.
        public double DamageReductionAmount { get; private set; }

        // Constructor for the DamageReduction class, which initializes the DamageReductionAmount property.
        public DamageReduction(double damageReduction)
        {
            // Check if the provided damage reduction value is less than 0.
            if (damageReduction < 0)
            {
                // If the damage reduction value is negative, throw an ArgumentException with a error message.
                throw new ArgumentException("Damage reduction must not be below 0");
            }

            // If the damage reduction value is valid, assign it to the DamageReductionAmount property.
            DamageReductionAmount = damageReduction;
        }
    }
}
