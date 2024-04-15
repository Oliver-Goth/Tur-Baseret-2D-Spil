using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    // Abstract class representing an object in the game world.
    public abstract class WorldObject
    {
        public string Name { get; set; } // The name of the world object.
        public bool Lootable { get; } // Indicates whether the object can be looted.
        public bool Removable { get; } // Indicates whether the object can be removed from the world.
        public int Position { get; set; } // The position of the object in the world.

        // Constructor for WorldObject.
        public WorldObject(string name, bool lootable, bool removable, int position)
        {
            // Initialize properties with provided values.
            Name = name;
            Lootable = lootable;
            Removable = removable;
            Position = position;
        }
    }
}
