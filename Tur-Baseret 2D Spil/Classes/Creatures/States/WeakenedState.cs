using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    // Represents a weakened state of an entity.
    public class WeakenedState : IState
    {
        // Calculates the damage given by the entity in the weakened state.
        public Damage.Damage CalculateGiveDamage(Damage.Damage given, Weapon? weapon)
        {
            // Check if the entity has an equipped weapon.
            if (weapon != null)
            {
                // If a weapon is equipped, calculate the total damage given by adding the base damage and the weapon's damage, then subtract 5.
                return new Damage.Damage((given.DamageAmount + weapon.DamageGive.DamageAmount) * 0.9);
            }

            // If no weapon is equipped, subtract 5 from the base damage.
            return new Damage.Damage(given.DamageAmount * 0.9);
        }

        // Calculates the damage taken by the entity in the weakened state.
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken, Armor? armor)
        {
            // Check if the entity has equipped armor.
            if (armor != null)
            {
                // If armor is equipped, calculate the total damage taken by subtracting the armor's damage reduction from the base damage, then add 5.
                return new Damage.Damage((taken.DamageAmount - armor.DamageReduction.DamageReductionAmount) * 1.1);
            }

            // If no armor is equipped, add 5 to the base damage.
            return new Damage.Damage(taken.DamageAmount * 1.1);
        }
    }
}
