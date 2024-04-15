using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Classes.World;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures
{
    // Factory class responsible for creating goblins.
    public class GoblinFactory
    {
        // Instance of the game logging interface for logging events.
        private IGameLogging GameLogging { get; set; }

        // Constructor for GoblinFactory.
        public GoblinFactory(IGameLogging gameLogging)
        {
            // Set the game logging instance.
            GameLogging = gameLogging;

            // Log that the factory has been created.
            GameLogging.WriteInformationToText("Factory created");
        }

        // Creates a goblin with the specified parameters.
        public Goblin CreateGoblin(Position position, int healthPoints, List<WearableItem> loot = null, string name = "Goblin")
        {
            // Create a new goblin instance.
            Goblin goblin = new Goblin(position, healthPoints, name, GameLogging, loot);

            // Log that the goblin has been created.
            GameLogging.WriteInformationToText("Goblin created: " + name);

            // Add the goblin to the game world.
            World.World.Instance.AddToWorld(goblin);

            // Return the created goblin object.
            return goblin;
        }
    }
}
