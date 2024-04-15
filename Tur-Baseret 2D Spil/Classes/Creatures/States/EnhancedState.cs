using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    // Represents an enhanced state of an entity.
    public class EnhancedState : IState
    {
        // Calculates the damage given by the creature, considering the given damage and equipped weapon.
        public Damage.Damage CalculateGiveDamage(Damage.Damage given, Weapon? weapon)
        {
            // Check if the creature has an equipped weapon.
            if (weapon != null)
            {
                // If a weapon is equipped, calculate the total damage given by adding the base damage and the weapon's damage, then add 5 extra damage.
                return new Damage.Damage((given.DamageAmount + weapon.DamageGive.DamageAmount) + 5);
            }

            // If no weapon is equipped, calculate the total damage given by adding the base damage and 5 extra damage.
            return new Damage.Damage(given.DamageAmount + 5);
        }

        // Calculates the damage taken by the creature, considering the taken damage and equipped armor.
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken, Armor? armor)
        {
            // Check if the creature has equipped armor.
            if (armor != null)
            {
                // If armor is equipped, calculate the total damage taken by subtracting the armor's damage reduction and 5 extra damage.
                return new Damage.Damage((taken.DamageAmount - armor.DamageReduction.DamageReductionAmount) - 5);
            }

            // If no armor is equipped, calculate the total damage taken by subtracting 5 extra damage.
            return new Damage.Damage(taken.DamageAmount - 5);
        }
    }
}
