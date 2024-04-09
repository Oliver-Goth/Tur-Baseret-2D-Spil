using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Damage
{
    /// <summary>
    /// Damage taken must never be negative
    /// </summary>
    public class Damage
    {
        public double DamageAmount { get; private set; }
        public Damage(double dmg)
        {
            if (dmg < 0)
            {
                throw new ArgumentException("Damage must not be below 0");
            }
            DamageAmount = dmg;
        }
    }
}
