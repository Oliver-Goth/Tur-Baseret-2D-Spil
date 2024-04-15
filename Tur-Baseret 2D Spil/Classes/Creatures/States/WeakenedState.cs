using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    // Represents a weakened state of an entity.
    internal class WeakenedState : IState
    {
        // Calculates the damage taken by the entity in the weakened state.
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
        {
            // Increase the damage taken by 1 when in the weakened state.
            return new Damage.Damage(taken.DamageAmount + 1);
        }
    }
}
