using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.Damage
{
    public class DamageReduction
    {
        public double DamageReductionAmount { get; private set; }
        public DamageReduction(double damageReduction)
        {
            if (damageReduction < 0)
            {
                throw new ArgumentException("Damage reduction must not be below 0");
            }
            DamageReductionAmount = damageReduction;
        }
    }
}
