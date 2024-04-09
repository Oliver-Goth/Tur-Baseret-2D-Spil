using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    internal class WeakenedState : IState
    {
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
        {
            return new Damage.Damage(taken.DamageAmount + 1);
        }
    }
}
