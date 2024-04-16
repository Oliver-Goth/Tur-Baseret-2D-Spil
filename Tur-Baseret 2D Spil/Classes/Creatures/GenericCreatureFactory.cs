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
    public class GenericCreatureFactory
    {
        private static IGameLogging GameLogging { get; set; }
        public GenericCreatureFactory(IGameLogging gameLogging)
        {
            GameLogging = gameLogging;
            GameLogging.WriteInformationToText("Factory created");
        }
        public static GenericCreature CreateCreature(Position position, int healthPoints, List<WearableItem>? loot = null, string name = "Creature")
        {
            GenericCreature creature = new GenericCreature(position, healthPoints, name, loot);
            GameLogging.WriteInformationToText("Minotaur created: " + name);
            World.World.Instance.AddToWorld(creature);
            return creature;
        }      
    }
}
