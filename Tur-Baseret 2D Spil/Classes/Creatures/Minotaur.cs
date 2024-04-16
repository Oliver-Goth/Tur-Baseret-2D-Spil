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
    public class Minotaur : Creature
    {
        public Minotaur(Position position, int health, string name, List<WearableItem>? carriedLoot) : base(position, name, health, carriedLoot)
        {
        }

        public override Damage.Damage GiveDamage()
        {
            return new Damage.Damage(RandomGenerator.Next(5, 20));
        }

        public override Damage.Damage TakeDamage(Damage.Damage taken)
        {
            Health -= taken.DamageAmount;
            return new Damage.Damage(taken.DamageAmount);
        }

        public override string ToString()
        {
            return $"------Creature: Minotaur------ \n" +
                $"Position: {Position}\n" +
                $"Name: {Name}\n" +
                $"hp: {Health}\n" +
                $"Loot: {string.Join(",",Loot)}\n";
        }
    }
}
