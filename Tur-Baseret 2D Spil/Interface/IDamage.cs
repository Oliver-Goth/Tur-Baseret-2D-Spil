using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Damage;

namespace Tur_Baseret_2D_Spil.Interface
{
    // Interface for objects that can give damage.
    public interface IGiveDamage
    {
        // Method signature for giving damage.
        public abstract Damage GiveDamage();
    }
}
