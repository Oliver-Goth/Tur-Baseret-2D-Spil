using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    abstract class Item
    {
        public string Name { get; } // Navnet på item

        // Constructor
        public Item(string name)
        {
            Name = name;
        }
    }
}
