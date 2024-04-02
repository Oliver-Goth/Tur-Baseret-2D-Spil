using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Classes.World;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil.Classes.Creatures
{
    // Klasse til at repræsentere en creatures
    abstract class Creature
    {
        public Position Position { get; protected set; }
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Level { get; protected set; }
        public int WorldLength { get; set; }
        public int WorldHeight { get; set; }
        List<Armor> Armor { get; set; }
        List<Weapon> Weapon { get; set; }

        //Constructor
        public Creature(string name, int health, int level)
        {
            Name = name;
            Health = health;
            Level = level;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Health: {Health}, Level: {Level}";
        }

        public void Hit(Creature target)
        {
            // Simpel logik for angreb
            if (Weapon.Count == 0)
            {
                // Hvis skabningen ikke har nogen våben, gør ingen skade
                Console.WriteLine("Denne skabning har ingen våben og kan ikke angribe.");
                return;
            }

            // Vælg et tilfældigt angrebsobjekt
            Random random = new Random();
            int index = random.Next(Weapon.Count);
            Weapon selectedAttack = Weapon[index];

            // Beregn afstand mellem de to skabninger
            double distance = Math.Sqrt(Math.Pow(target.WorldLength - WorldLength, 2) + Math.Pow(target.WorldHeight - WorldHeight, 2));

            // Hvis målet er inden for rækkevidden, udfør angrebet
            if (distance <= selectedAttack.Range)
            {
                target.ReceiveHit(selectedAttack.Durability);
                Console.WriteLine($"Angrebet med {selectedAttack.Name} ramte!");
            }
            else
            {
                Console.WriteLine($"Målet er for langt væk for at {selectedAttack.Name} kan ramme.");
            }
        }

        public void ReceiveHit(int health)
        {
            // Modtag angreb
            foreach (Armor defense in Armor)
            {
                // Reducer skade ved hjælp af Armor
                health -= defense.Defence;
            }

            if (health > 0)
            {
                Health -= health;
                Console.WriteLine($"Modtog {health} skade. Livspunkter tilbage: {Health}");
            }
            else
            {
                Console.WriteLine("Skaden blev blokeret af forsvaret.");
            }

            // Hvis livspunkter falder til eller under 0, dø
            if (Health <= 0)
            {
                Console.WriteLine("Skabningen er død!");
            }
        }

        public void Loot(WorldObject worldObject)
        {
            // Implementer logikken for at samle objekter op
        }
    }
}