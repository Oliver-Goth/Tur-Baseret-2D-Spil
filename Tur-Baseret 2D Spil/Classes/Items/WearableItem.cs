using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    public abstract class WearableItem : IWearableItem
    {
        public string Name { get; set; }
        public int Durability { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }

        public WearableItem(string name, int durability, int type, string description)
        {
            Name = name;
            Durability = durability;
            Type = type;
            Description = description;
        }
    }
}
