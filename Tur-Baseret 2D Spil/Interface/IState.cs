using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Damage;
using static System.Net.Mime.MediaTypeNames;

namespace Tur_Baseret_2D_Spil.Interface
{
    public interface IState
    {
        Damage CalculateTakeDamage(Damage taken);
    }
}
