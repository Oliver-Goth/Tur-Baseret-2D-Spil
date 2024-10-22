﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tur_Baseret_2D_Spil.Classes.Damage;
using Tur_Baseret_2D_Spil.Classes.Items;
using static System.Net.Mime.MediaTypeNames;

namespace Tur_Baseret_2D_Spil.Interface
{
    // Interface for defining different states of an entity.
    public interface IState
    {
        // Calculates the damage taken by the entity based on its current state.
        Damage CalculateTakeDamage(Damage taken, Armor? armor);

        // Calculates the damage given by the entity based on its current state.
        Damage CalculateGiveDamage(Damage given, Weapon? weapon);
    }
}
