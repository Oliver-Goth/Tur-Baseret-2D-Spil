using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Classes.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures
{
    // The Class to represent creature
    public abstract class Creature : ITakeDamage, IGiveDamage
    {
        public string Name { get; protected set; } // Property to hold the name of the creature.
        public double Health { get; protected set; } // Property to hold the health points of the creature.
        public int Level { get; protected set; } // Property to hold the level of the creature.
        public Position Position { get; protected set; } // Property to hold the position of the creature.
        public List<WearableItem> Loot { get; protected set; } // Property to hold the loot carried by the creature.
        public IGameLogging GameLogging { get; protected set; } // Property to hold a reference to the game logging interface.
        protected Random RandomGenerator = new Random(); // Property to generate random numbers.

        // Property to check if the player is dead.
        public bool IsDead
        {
            get { return Health <= 0; } // Property to check if the creature is dead.
        }

        // Constructor to initialize a creature with provided attributes.
        public Creature(Position position, string name, int healthPoints, List<WearableItem> carriedLoot, IGameLogging gameLogging)
        {
            Position = position;
            // Simplified the initialization of Loot property.
            Loot = carriedLoot != null ? carriedLoot : new List<WearableItem>();
            Name = name;
            Health = healthPoints;
            GameLogging = gameLogging;
            GameLogging.WriteInformationToText("Created creature with the name: " + Name);
        }

        // Abstract method to handle damage taken by the creature.
        public abstract Damage.Damage TakeDamage(Damage.Damage taken);
    
        // Abstract method to determine the damage given by the creature.
        public abstract Damage.Damage GiveDamage();
    }
}