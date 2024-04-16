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
    public class MinotaurFactory
    {
        private static IGameLogging GameLogging { get; set; }
        public MinotaurFactory(IGameLogging gameLogging)
        {
            GameLogging = gameLogging;
            GameLogging.WriteInformationToText("Factory created");
        }
        public static Minotaur CreateMinotaur(Position position, int healthPoints, List<WearableItem>? loot = null, string name = "Minotaur")
        {
            Minotaur minotaur = new Minotaur(position, healthPoints, name, loot);
            GameLogging.WriteInformationToText("Minotaur created: " + name);
            World.World.Instance.AddToWorld(minotaur);
            return minotaur;
        }
    }
}
