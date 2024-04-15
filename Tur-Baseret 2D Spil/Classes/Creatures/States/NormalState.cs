using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    // Represents a normal state of an entity.
    public class NormalState : IState
    {
        // Calculates the damage taken by the entity in the normal state.
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
        {
            // In the normal state, the entity takes the same amount of damage as received.
            return taken;
        }
    }

}
