//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Tur_Baseret_2D_Spil.Classes.Items;
//using Tur_Baseret_2D_Spil.Classes.World;
//using Tur_Baseret_2D_Spil.Interface;

//namespace Tur_Baseret_2D_Spil.Classes.Creatures
//{
//    // This class represents a Goblin creature in the game, inheriting from the Creature class.
//    public class Goblin : Creature
//    {
//        // Constructor for creating a Goblin instance with specified position, health, name, carried loot, and game logging.
//        // Inherits the constructor from the base Creature class.
//        public Goblin(Position position, int health, string name, List<WearableItem> carriedLoot, IGameLogging gameLogging) : base(position, name, health, carriedLoot)
//        {
//        }

//        // Overrides the GiveDamage method inherited from the Creature class.
//        // Generates and returns a random amount of damage dealt by the Goblin.
//        public override Damage.Damage GiveDamage()
//        {
//            return new Damage.Damage(RandomGenerator.Next(5, 20));
//        }

//        // Overrides the TakeDamage method inherited from the Creature class.
//        // Reduces the Goblin's health by the amount of damage taken.
//        // Returns a Damage object representing the amount of damage taken.
//        public override Damage.Damage TakeDamage(Damage.Damage taken)
//        {
//            Health -= taken.DamageAmount;
//            return new Damage.Damage(taken.DamageAmount);
//        }
//    }
//}
