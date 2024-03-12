using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    // Klasse til at repræsentere verdenen
    public class World
    {
        public string Name { get; set; }

        private static World _instance = new World();

        public static World Instance = _instance;

        public int MaxX;
        public int MaxY;

        public World()
        {
            MaxX = 32;
            MaxY = 32;
        }


    }
}
