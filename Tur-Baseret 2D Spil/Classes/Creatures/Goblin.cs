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
    public class Goblin : Creature
    {
        public Goblin(Position position, int health, string name, List<WearableItem> carriedLoot, IGameLogging gameLogging) : base(position, health, name, carriedLoot, gameLogging)
        {
        }

        public override Damage.Damage GiveDamage()
        {
            return new Damage.Damage(RandomGenerator.Next(5, 20));
        }

        public override Damage.Damage TakeDamage(Damage.Damage taken)
        {
            health -= taken.DamageAmount;
            return new Damage.Damage(taken.DamageAmount);
        }
    }
}
