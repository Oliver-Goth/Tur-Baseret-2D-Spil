using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    // Klasse til at repræsentere et våben, der nedarver fra Item
    abstract class Weapon : Item
    {
        public int Damage { get; } // Skaden, som våbnet gør

        //Constructor
        public Weapon(string name, int damage = 0) : base(name)
        {
            Damage = damage;
        }

        // Metode til at udføre et angreb og returnere skaden
        public int Attack()
        {
            return Damage;
        }
    }
}
