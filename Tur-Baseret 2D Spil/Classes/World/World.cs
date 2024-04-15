using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Tur_Baseret_2D_Spil.Interface;
using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Classes.Creatures;

namespace Tur_Baseret_2D_Spil.Classes.World
{
    public class World
    {
        
        public string Name { get; private set; } // Name of the world
        public int WorldLength { get; private set; } // The X axis of the world
        private int length; // Used to parse world length, from config
        public int WorldHeight { get; private set; } // The Y axis of the world
        private int height; // Used to parse world height, from config
        private XmlDocument? configDocument = new XmlDocument(); // Used to handle loading in the config document
        private IGameLogging GameLogging; // Used for gamelogging
        private List<WorldObject> WorldObjectList = new List<WorldObject>(); // List for all objects in the world
        private static World? instance; // Instance for Singleton

        // Provides a singleton instance of the World class.
        public static World Instance
        {
            get
            {
                // Check if the instance has been initialized.
                if (instance == null)
                {
                    // If not initialized, create a new instance of the World class.
                    instance = new World();
                }
                // Return the instance of the World class.
                return instance;
            }
        }

        // Private constructor for the World class.
        private World()
        {
            // Initialize the GameLogging property with the instance of the game logging system.
            GameLogging = Logging.GameLogging.Instance;

            // Load the WorldConfig.xml document.
            configDocument.Load("WorldConfig.xml");

            // Extract and set the name of the world from the configuration file.
            XmlNode? nameNode = configDocument.DocumentElement?.SelectSingleNode("Name");
            if (nameNode != null)
            {
                Name = nameNode.InnerText.Trim();
            }
            else
            {
                // Log a warning if the world name is not found in the configuration file.
                GameLogging.WriteWarningToText("World name not found");

                // Set a default name for the world.
                Name = "Standard world";
            }
            // Log the name of the world.
            GameLogging.WriteInformationToText("World name: " + Name);

            // Extract and set the length of the world from the configuration file.
            XmlNode lengthNode = configDocument.DocumentElement?.SelectSingleNode("Length");
            if (int.TryParse(lengthNode?.InnerText.Trim(), out length))
            {
                WorldLength = length;
            }
            else
            {
                // Set a default length for the world if it's not found or is invalid.
                WorldLength = 25;
            }
            // Log the length of the world.
            GameLogging.WriteInformationToText("World length: " + WorldLength);

            // Extract and set the height of the world from the configuration file.
            XmlNode heightNode = configDocument.DocumentElement?.SelectSingleNode("Height");
            if (int.TryParse(heightNode?.InnerText.Trim(), out height))
            {
                WorldHeight = height;
            }
            else
            {
                // Set a default height for the world if it's not found or is invalid.
                WorldHeight = 25;
            }
            // Log the height of the world.
            GameLogging.WriteInformationToText("World height: " + WorldHeight);
        }

        // Checks if a given position is inside the boundaries of the world.
        public bool InsideWorld(Position position)
        {
            // Check if the X or Y coordinates are less than zero,
            // which means the position is outside the world boundaries.
            if (position.X < 0 || position.Y < 0)
            {
                return false;
            }

            // Check if the X or Y coordinates are greater than the world length or height,
            // which means the position is outside the world boundaries.
            if (position.X > WorldLength || position.Y > WorldHeight)
            {
                return false;
            }

            // If the position passes both checks, it's inside the world boundaries.
            return true;
        }

        // Adds a world object to the list of world objects.
        public void AddToWorld(WorldObject worldObject)
        {
            // Add the specified world object to the list of world objects.
            WorldObjectList.Add(worldObject);
        }

        // Removes a world object from the list of world objects.
        public void RemoveFormWorld(WorldObject worldObject)
        {
            // Remove the specified world object from the list of world objects.
            WorldObjectList.Remove(worldObject);
        }

        // Retrieves all creatures currently in the world.
        public List<Creature> GetCreaturesInWorld()
        {
            // Filter the list of world objects to include objects of type Creature,
            // then convert the filtered objects to a new list.
            return new List<Creature>(WorldObjectList.OfType<Creature>().ToList());
        }

        // Retrieves all loot containers currently in the world.
        public List<WorldObject> GetLootContainersInWorld()
        {
            // Filter the list of world objects to include objects of type WorldObject,
            // then convert the filtered objects to a new list.
            return new List<WorldObject>(WorldObjectList.OfType<WorldObject>().ToList());
        }
    }
}
