using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Damage;

namespace Tur_Baseret_2D_Spil.Interface
{
    public interface ITakeDamage
    {
        public abstract Damage TakeDamage(Damage taken);
    }
}
