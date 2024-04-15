using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    // Represents an enhanced state of an entity.
    public class EnhancedState : IState
    {
        // Calculates the damage taken by the entity in the enhanced state.
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
        {
            // Decrease the damage taken by 1 when in the enhanced state.
            return new Damage.Damage(taken.DamageAmount - 1);
        }
    }
}
