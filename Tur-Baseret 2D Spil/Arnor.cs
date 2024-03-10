
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    // Klasse til at repræsentere en rustning, der nedarver fra Item
    abstract class Armor : Item
    {
        public int Defense { get; } // Forsvaret, som rustningen giver

        //Constructor
        public Armor(string name, int defense = 0) : base(name)
        {
            Defense = defense;
        }
    }
}
