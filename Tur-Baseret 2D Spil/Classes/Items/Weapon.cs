using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    // Klasse til at repræsentere et våben, der nedarver fra Item
    public abstract class Weapon : WearableItem
    {
        public int Damage { get; set; }
        public int Range { get; set; }
        public Damage.Damage DamageGive { get; private set; }

        //Constructor
        public Weapon(string name, int durability, int range, string description, Damage.Damage damage) : base(name, 100, 2, description)
        {
            DamageGive = damage;
        }

    }
}
