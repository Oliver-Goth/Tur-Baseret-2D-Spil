using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Creatures.States;
using Tur_Baseret_2D_Spil.Classes.Durabilityase;
using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Classes.World;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures
{
    // Player to be controlled
    public class Player
    {
        public string Name { get; private set; } // Property to hold the name of the player
        public double HealthPoints { get; private set; } // Property to hold the health of the player
        public Position Position { get; set; } // Property to hold the position of the player
        public List<WearableItem> Inventory { get; }  // Property to hold the loot carried by the player.
        public IState State { get; private set; } // Property to hold a reference to the state interface.
        private IGameLogging GameLogging { set; get; } // Property to hold a reference to the game logging interface.
        public Armor? EquippedArmor { get; private set; } = null; // Property to hold a reference to armor carried by the player.
        public Weapon? EquippedWeapon { get; private set; } = null; // Property to hold a reference to weapon carried by the player.
        private Random RandomGenerator = new Random(); // Property to generate random numbers.

        // Property to check if the player is poisoned.
        public bool IsPoisoned
        {
            get
            {
                return State.GetType() == typeof(WeakenedState); // Check if the current state of the player is WeakenedState.
            }
        }

        // This property determines if the entity is dead based on its health points.
        public bool IsDead
        {
            // Using get to return true if health points are less than zero, indicating death.
            get { return HealthPoints < 0; }
        }

        // Constructor for the Player class.
        // Initializes a new instance of the Player class with the specified parameters.
        public Player(string name, IGameLogging gameLogging, int healthPoints = 100)
        {
            Name = name; // Set the name of the player.

            HealthPoints = healthPoints; // Set the initial health points of the player.

            Position = new Position(0, 0); // Set the initial position of the player to (0,0).

            Inventory = new List<WearableItem>(); // Initialize the player's inventory as an empty list.

            State = new NormalState(); // Set the initial state of the player to NormalState.

            GameLogging = gameLogging; // Set the game logging object for the player.

            GameLogging.WriteInformationToText(Name + " was created"); // Log the creation of the player.
        }

        // Adds a wearable item to the player's inventory.
        public void AddToInventory(WearableItem item)
        {
            // Add the item to the player's inventory list.
            Inventory.Add(item);

            // Log the addition of the item to the inventory.
            GameLogging.WriteInformationToText("Added item " + item.Name + " to inventory");
        }

        // Retrieves all armor items from the player's inventory.
        public List<Armor> GetArmor()
        {
            // Returns a list containing all armor items currently in the player's inventory.
            return new List<Armor>(Inventory.OfType<Armor>().ToList());
        }

        // Retrieves all weapon items from the player's inventory.
        public List<Weapon> GetWeapon()
        {
            // Returns a list containing all weapon items currently in the player's inventory.
            return new List<Weapon>(Inventory.OfType<Weapon>().ToList());
        }

        // Destroys a wearable item from the player's inventory.
        public void CheckDurability(WearableItem item)
        {
            // Check if the item's durability is less than or equal to zero.
            if (item.Durability <= 0)
            {
                // Remove the item from the player's inventory.
                Inventory.Remove(item);

                // Log the destruction of the item.
                GameLogging.WriteInformationToText(item.Name + " was destroyed");
            }
        }

        // Calculates the damage taken by the creature, taking into account its current state and equipped armor.
        public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
        {
            // Calculate the damage to take based on the creature's state and equipped armor.
            Damage.Damage dmgToTake = State.CalculateTakeDamage(taken, armor: EquippedArmor);

            // Reduce the creature's health points by the amount of damage taken.
            HealthPoints -= dmgToTake.DamageAmount;

            // Return the adjusted damage taken by the creature.
            return dmgToTake;
        }

        // Calculates the damage given by the creature, taking into account its current state and equipped weapon.
        public Damage.Damage CalculateGiveDamage()
        {
            // Calculate the damage to give based on the creature's state and equipped weapon.
            return State.CalculateGiveDamage(new Damage.Damage(RandomGenerator.Next(3, 5)), weapon: EquippedWeapon);
        }

        // Checks if the player is dead.
        public void CheckIfDead()
        {
            // Check if the creature's health points fall below zero.
            if (HealthPoints < 0)
            {
                // Change the player's state to DeadState.
                State = new DeadState();

                // Log the death of the player.
                GameLogging.WriteInformationToText(Name + " was killed");
            }
        }

        // Weakens the player by changing their state to a WeakenedState.
        // Updates the player's state and logs the event.
        public void WeakenPlayer()
        {
            // Change the player's state to WeakenedState.
            State = new WeakenedState();

            // Log that the player has been weakened.
            GameLogging.WriteInformationToText("Player has been weakened");
        }

        // Changes the player by changing their state to a NormalState.
        // Updates the player's state and logs the event.
        public void CurePlayer()
        {
            // Change the player's state to NormalState.
            State = new NormalState();

            // Log that the player has been cured.
            GameLogging.WriteInformationToText("Player has been cured");
        }

        // Boosts the player by changing their state to a EnhancedState.
        // Updates the player's state and logs the event.
        public void EnhancePlayer()
        {
            // Change the player's state to EnhancedState.
            State = new EnhancedState();

            // Log that the player has been boosted.
            GameLogging.WriteInformationToText("Player has been enhanced");
        }

        // Moves the player to a specified position if it's inside the world boundaries.
        public bool MoveToPosition(Position position)
        {
            // Check if the specified position is inside the world boundaries.
            if (World.World.Instance.InsideWorld(position))
            {
                // If the position is valid, update the player's position.
                Position = position;
                // Return true to indicate successful movement.
                return true;
            }
            // Return false if the specified position is outside the world boundaries.
            return false;
        }

        // Equips a armor item to the player.
        public void EquipDefensive(Armor item)
        {
            // If the player already has equipped armor, add it back to the inventory.
            if (EquippedArmor != null)
            {
                AddToInventory(EquippedArmor);
            }
            // Equip the new armor item.
            EquippedArmor = item;
        }

        // Equips a weapon item to the player.
        public void EquipWeapon(Weapon item)
        {
            // If the player already has an equipped weapon, add it back to the inventory.
            if (EquippedWeapon != null)
            {
                AddToInventory(EquippedWeapon);
            }
            // Equip the new weapon item.
            EquippedWeapon = item;
        }
    }
}
