using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.World
{
    // Represents a position in a 2D coordinate system.
    public class Position
    {
        public int X; // The X-coordinate of the position.
        public int Y; // The Y-coordinate of the position.

        // Constructor for Position.
        public Position(int x, int y)
        {
            // Initialize the X and Y coordinates with the provided values.
            X = x;
            Y = y;
        }
    }
}
