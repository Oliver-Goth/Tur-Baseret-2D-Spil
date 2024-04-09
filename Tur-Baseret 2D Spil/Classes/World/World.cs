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
        // Name of the world
        public string Name { get; private set; }

        // The X axis of the world
        public int WorldLength { get; private set; }

        // Used to parse world length, from config
        private int length;

        // The Y axis of the world
        public int WorldHeight { get; private set; }

        // Used to parse world height, from config
        private int height;

        // Used to handle loading in the config document
        private XmlDocument? configDocument = new XmlDocument();

        // Used for gamelogging
        private IGameLogging GameLogging;

        // List for all objects in the world
        private List<WorldObject> WorldObjectList = new List<WorldObject>();
        
        // Instance for Singleton
        private static World? instance;

        // Getting the instance for Singleton
        public static World Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new World();
                }
                return instance;
            }
        }

        /// <summary>
        /// Loads values from a config file
        /// If values aren't found, default values are loaded
        /// </summary>
        private World()
        {
            GameLogging = Logging.GameLogging.Instance;
            configDocument.Load("WorldConfig.xml");
            XmlNode? nameNode = configDocument.DocumentElement.SelectSingleNode("Name");
            if (nameNode != null)
            {
                Name = nameNode.InnerText.Trim();
            }
            else
            {
                GameLogging.WriteWarningToText("World name not found");
                Name = "Standard world";
            }
            GameLogging.WriteInformationToText("World name: " + Name);

            XmlNode lengthNode = configDocument.DocumentElement.SelectSingleNode("Length");
            if (int.TryParse(lengthNode.InnerText.Trim(), out length))
            {
                WorldLength = length;
            }
            else
            {
                WorldLength = 10;
            }
            GameLogging.WriteInformationToText("World length: " + WorldLength);

            XmlNode heightNode = configDocument.DocumentElement.SelectSingleNode("Height");
            if (int.TryParse(heightNode.InnerText.Trim(), out height))
            {
                WorldHeight = height;
            }
            else
            {
                WorldHeight = 10;
            }
            GameLogging.WriteInformationToText("World height: " + WorldHeight);
        }

        /// <summary>
        /// Determines if a position is inside the world or not
        /// </summary>
        /// <param name="position">The position in the world</param>
        /// <returns>False if position is not in the world. True if the position is in the world</returns>
        public bool InsideWorld(Position position)
        {
            if(position.X < 0 || position.Y < 0)
            {
                return false;
            }
            if(position.X > WorldLength || position.Y > WorldHeight)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Adds an object to the world
        /// </summary>
        /// <param name="worldObject">The object to be in the world</param>
        public void AddToWorld(WorldObject worldObject)
        {
            WorldObjectList.Add(worldObject);
        }

        /// <summary>
        /// Removes an object from the world
        /// </summary>
        /// <param name="worldObject">Objects to be removed from the world</param>
        public void RemoveFormWorld(WorldObject worldObject)
        {
            WorldObjectList.Remove(worldObject);
        }

        /// <summary>
        /// Get a list of creatures in the world
        /// </summary>
        /// <returns>A copy of the list, of the creatures</returns>
        public List<Creature> GetCreaturesInWorld()
        {
            return new List<Creature>(WorldObjectList.OfType<Creature>().ToList());
        }

        /// <summary>
        /// Get a list of world objects in the world
        /// </summary>
        /// <returns>A copy of the list, of the world objects</returns>
        public List<WorldObject> GetLootContainersInWorld()
        {
            return new List<WorldObject>(WorldObjectList.OfType<WorldObject>().ToList());
        }
    }
}
