using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Interface
{
    public interface IWearableItem
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
    }
}
