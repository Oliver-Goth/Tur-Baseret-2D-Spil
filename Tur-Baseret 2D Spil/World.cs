using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    // Klasse til at repræsentere verdenen
    abstract class World
    {
        // Liste over creatures i verdenen
        public List<Creature> Creatures { get; }

        // Constructor
        public World()
        {
            Creatures = new List<Creature>();
        }

        // Metode til at tilføje en creature til verdenen
        public void AddCreature(Creature creature)
        {
            Creatures.Add(creature);
        }
    }
}
