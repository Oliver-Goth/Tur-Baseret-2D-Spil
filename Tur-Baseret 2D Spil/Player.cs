using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    // Klasse til at repræsentere Player, der nedarver fra Creature
    abstract class Player : Creature
    {
        // Constructor
        public Player(string name, int health = 150) : base(name, health) { }
    }
}
