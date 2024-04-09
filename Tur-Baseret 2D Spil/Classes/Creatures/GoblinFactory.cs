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
    public class GoblinFactory
    {
        private IGameLogging GameLogging { get; set; }

        public GoblinFactory(IGameLogging gameLogging)
        {
            GameLogging = gameLogging;
            GameLogging.WriteInformationToText("Factory created");
        }

        public Goblin CreateMinotaur(Position position, int healthPoints, List<WearableItem> loot, string name = "Goblin")
        {
            Goblin goblin = new Goblin(position, healthPoints, name, GameLogging, loot);
            GameLogging.WriteInformationToText("Goblin created: " + name);
            World.World.Instance.AddToWorld(goblin);
            return goblin;
        }
    }
}
