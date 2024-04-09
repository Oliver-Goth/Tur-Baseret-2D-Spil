using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Creatures.States;
using Tur_Baseret_2D_Spil.Classes.Items;
using Tur_Baseret_2D_Spil.Classes.World;
using Tur_Baseret_2D_Spil.Interface;

namespace Tur_Baseret_2D_Spil.Classes.Creatures
{
    /// <summary>
    /// Player to be controlled
    /// </summary>
    public class Player
    {
        public string Name { get; private set; }
        public double HealthPoints { get; private set; }
        public Position Position { get; set; }
        public List<WearableItem> Inventory { get; }
        public IState State { get; private set; }
        private IGameLogging GameLogging { set; get; }
        // The equipped defense item a player, CAN have
        public Armor? EquippedArmor { get; private set; } = null;
        // The equipped offensive item a player, CAN have
        public Weapon? EquippedWeapon { get; private set; } = null;
        // Used to generate the possible damage
        private Random RandomGenerator = new Random();

        public bool IsPoisoned
        {
            get
            {
                return State.GetType() == typeof(WeakenedState);
            }
        }

        public bool IsDead
        {
            get { return HealthPoints < 0; }
        }

        public Player(string name, IGameLogging gameLogging, int healthPoints = 100)
        {
            Name = name;
            HealthPoints = healthPoints;
            Position = new Position(0, 0);
            Inventory = new List<WearableItem>();
            State = new NormalState();
            GameLogging = gameLogging;
            GameLogging.WriteInformationToText(Name + " was created");
        }

        /// <summary>
        /// Adds item to inventory
        /// </summary>
        /// <param name="item">Item to be added to the inventory</param>
        public void AddToInventory(WearableItem item)
        {
            Inventory.Add(item);
            GameLogging.WriteInformationToText("Added item " + item.Name + " to inventory");
        }

        /// <summary>
        /// Gets offensive items from the players inventory
        /// </summary>
        /// <returns>List of offensive items</returns>
        public List<Armor> GetArmor()
        {
            return new List<Armor>(Inventory.OfType<Armor>().ToList());
        }

        /// <summary>
        /// Gets defensive items from the players inventory
        /// </summary>
        /// <returns>List of defensive items</returns>
        public List<Weapon> GetWeapon()
        {
            return new List<Weapon>(Inventory.OfType<Weapon>().ToList());
        }

        public Damage.Damage CalculateTakeDamage(Damage.Damage taken)
        {
            return State.CalculateTakeDamage(taken);
        }

        /// <summary>
        /// Method meant to called when something poisons the player
        /// </summary>
        public void PoisonPlayer()
        {
            State = new WeakenedState();
            GameLogging.WriteInformationToText("Player has been weakened");
        }

        /// <summary>
        /// Method meant to remove status effects on a player
        /// </summary>
        public void CurePlayer()
        {
            State = new NormalState();
            GameLogging.WriteInformationToText("Player has been cured");
        }

        /// <summary>
        /// Method meant to called when something or someone enhances the player
        /// </summary>
        public void EnhancePlayer()
        {
            State = new EnhancedState();
            GameLogging.WriteInformationToText("Player has been enhanced");
        }

        /// <summary>
        /// Used to move to a new position in the world
        /// </summary>
        /// <param name="position">The new position in the world</param>
        /// <returns>Returns true, if the position is in the world and sets the position. Else false, if the position is not in the world</returns>
        public bool MoveToPosition(Position position)
        {
            if (World.World.Instance.InsideWorld(position))
            {
                Position = position;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Equips an offensive item
        /// If an item is already equipped, the previous item gets put in the inventory
        /// </summary>
        /// <param name="item">The defensive item to be equipped</param>
        public void EquipDefensive(Armor item)
        {
            if (EquippedArmor != null)
            {
                AddToInventory(EquippedArmor);
            }
            EquippedArmor = item;
        }

        /// <summary>
        /// Equips an offensive item
        /// If an item is already equipped, the previous item gets put in the inventory
        /// </summary>
        /// <param name="item">The offensive item to be equipped</param>
        public void EquipWeapon(Weapon item)
        {
            if (EquippedWeapon != null)
            {
                AddToInventory(EquippedWeapon);
            }
            EquippedWeapon = item;
        }
    }
}
