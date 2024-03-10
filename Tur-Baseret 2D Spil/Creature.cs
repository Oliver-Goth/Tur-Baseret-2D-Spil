using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tur_Baseret_2D_Spil
{
    // Klasse til at repræsentere en creatures
    abstract class Creature
    {
        public string Name { get; }
        public int Health { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }

        //Constructor
        public Creature(string name, int health = 100)
        {
            Name = name;
            Health = health;
        }

        // Metode til at nogle et rustning
        public void EquipArmor(Armor armor)
        {
            Armor = armor;
        }

        // Metode til at nogle et våben
        public void EquipWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }

        // Metode til at angribe
        public void Attack(Creature target)
        {
            if (Weapon != null)
            {
                int damage = Weapon.Attack(); // Beregn skade
                if (target.Armor != null) // Hvis målet har rustning
                {
                    damage -= target.Armor.Defense; // Træk rustningens forsvar fra skaden
                }
                target.Health -= damage; // Anvend skaden på målets helbred
                Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage."); // Udskriv angreb
                if (target.Health <= 0) // Hvis målet er dødt
                {
                    Console.WriteLine($"{target.Name} is defeated!"); // Udskriv at målet er besejret
                }
            }
            else // Hvis skabningen ikke har et våben
            {
                Console.WriteLine($"{Name} has no weapon to attack with!"); // Udskriv at skabningen ikke har et våben
            }
        }
    }
}