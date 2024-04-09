using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures.States
{
    public class NormalState : IState
    {
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
        {
            return taken;
        }
    }
}
