using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.World
{
    public class World
    {
        public string Name { get; private set; }
        public int WorldLength { get; private set; }
        private int length;
        public int WorldHeight { get; private set; }
        private int height;
        private XmlDocument? configDocument = new XmlDocument();

        public World(IGameLogging gameLogging)
        {
            configDocument.Load("WorldConfig.xml");
            XmlNode? nameNode = configDocument.DocumentElement.SelectSingleNode("Name");
            if (nameNode != null)
            {
                Name = nameNode.InnerText.Trim();
            }
            else
            {
                Name = "Standard world";
            }
            gameLogging.WriteInformationToText("World name: " + Name);

            XmlNode lengthNode = configDocument.DocumentElement.SelectSingleNode("Length");
            if (int.TryParse(lengthNode.InnerText.Trim(), out length))
            {
                WorldLength = length;
            }
            else
            {
                WorldLength = 10;
            }
            gameLogging.WriteInformationToText("World length: " + WorldLength);

            XmlNode heightNode = configDocument.DocumentElement.SelectSingleNode("Height");
            if (int.TryParse(heightNode.InnerText.Trim(), out height))
            {
                WorldHeight = height;
            }
            else
            {
                WorldHeight = 10;
            }
            gameLogging.WriteInformationToText("World height: " + WorldHeight);
        }
    }
}
