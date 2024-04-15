using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    // Abstract class representing a wearable item in the game.
    public abstract class WearableItem
    {
        public string Name { get; set; } // The name of the wearable item.
        public double Durability { get; set; } // The durability of the wearable item.
        public string Type { get; set; } // The type of the wearable item.
        public string Description { get; set; } // The description of the wearable item.

        // Constructor for WearableItem.
        public WearableItem(string name, double durability, string type, string description)
        {
            // Initialize properties with provided values.
            Name = name;
            Durability = durability;
            Type = type;
            Description = description;
        }
    }
}
