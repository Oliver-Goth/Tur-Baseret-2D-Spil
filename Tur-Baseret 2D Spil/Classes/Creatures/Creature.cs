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
    // Klasse til at repræsentere en creatures
    public abstract class Creature : ITakeDamage, IGiveDamage
    {
        // The creatures position in the world
        public Position Position { get; protected set; }

        // The name of a creature
        public string Name { get; protected set; }

        // Amount of health points a creature have
        public int Health { get; protected set; }

        // Amount of levels a creature have
        public int Level { get; protected set; }

        // Loot, the creature is carrying
        public List<WearableItem> Loot { get; protected set; }

        // Used to log trace/logging
        public IGameLogging GameLogging { get; protected set; }

        // Returns true, if a creature is dead
        public bool IsDead
        {
            get { return Health < 0; }
        }

        //Constructor
        public Creature(Position position, int healthPoints, string name, List<WearableItem> carriedLoot, IGameLogging gameLogging)
        {
            Position = position;
            Loot = carriedLoot;
            Health = healthPoints;
            Name = name;
            GameLogging = gameLogging;
            GameLogging.WriteInformationToText("Creature created with name: " + Name);
        }

        /// <summary>
        /// Calculates how much damage a creature takes
        /// </summary>
        /// <param name="taken">Amount of damage the creature taken</param>
        /// <returns>The actual amount a creature takes</returns>
        public abstract Damage.Damage TakeDamage(Damage.Damage taken);
        
        /// <summary>
        /// Calculates how much damage a creature gives
        /// </summary>
        /// <returns>The amount of damage to give</returns>
        public abstract Damage.Damage GiveDamage();
    }
}