using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    // Represents the state of a creature when it is dead.
    public class DeadState : IState
    {
        // Calculates the damage given by the creature in the dead state.
        public Damage.Damage CalculateGiveDamage(Damage.Damage given, Weapon? weapon)
        {
            // As the creature is dead, it cannot deal any damage. Return a Damage object representing zero damage.
            return new Damage.Damage(0);
        }

        // Calculates the damage taken by the creature in the dead state.
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken, Armor? armor)
        {
            // As the creature is dead, it cannot take any damage. Return a Damage object representing zero damage.
            return new Damage.Damage(0);
        }

        public void DeadPosition(int x, int y)
        {
            x = 0;
            y = 0;
        }
    }
}
