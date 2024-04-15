using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Damage;

namespace Tur_Baseret_2D_Spil.Interface
{
    // Interface for objects that can take damage.
    public interface ITakeDamage
    {
        // Method signature for taking damage.
        Damage TakeDamage(Damage taken);
    }
}
