using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    // Represents a normal state of an entity.
    public class NormalState : IState
    {
        // Calculates the damage given by the creature, considering the given damage and equipped weapon.
        public Damage.Damage CalculateGiveDamage(Damage.Damage given, Weapon? weapon)
        {
            // Check if the creature has an equipped weapon.
            if (weapon != null)
            {
                // If a weapon is equipped, calculate the total damage given by adding the base damage and the weapon's damage.
                return new Damage.Damage(given.DamageAmount + weapon.DamageGive.DamageAmount);
            }

            // If no weapon is equipped, return the base damage.
            return new Damage.Damage(given.DamageAmount);
        }

        // Calculates the damage taken by the creature, considering the taken damage and equipped armor.
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken, Armor? armor)
        {
            // Check if the creature has equipped armor.
            if (armor != null)
            {
                // If armor is equipped, calculate the total damage taken by subtracting the armor's damage reduction from the base damage.
                return new Damage.Damage(taken.DamageAmount - armor.DamageReduction.DamageReductionAmount);
            }

            // If no armor is equipped, return the base damage.
            return taken;
        }
    }

}
