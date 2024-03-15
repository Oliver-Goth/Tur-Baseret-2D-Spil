
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Tur_Baseret_2D_Spil.Classes.Items
{
    // Klasse til at repræsentere en rustning, der nedarver fra Item
    internal class Armor : WearableItem
    {
        public int Defence { get; set; }


        //Constructor
        public Armor(string name, int defence, int durability, string description) : base(name, 100, 2, description)
        {
            Name = name;
            Defence = defence;
            Durability = durability;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Defence: {Defence}";
        }
    }
}
