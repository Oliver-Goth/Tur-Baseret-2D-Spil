using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    internal class WorldObject
    {
        public string Name { get; set; } // Navnet på item
        public bool Lootable { get; } //Kan man samle item op
        public bool Removable { get; } //Kan man fjerne item
        public int Position { get; set; } //Position i world

        // Constructor
        public WorldObject(string name, bool lootable, bool removable, int position)
        {
            Name = name;
            Lootable = lootable;
            Removable = removable;
            Position = position;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Lootable: {Lootable}, Removable: {Removable}, Position: {Position}";
        }
    }
}
