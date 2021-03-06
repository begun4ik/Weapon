﻿using System;

namespace Weapon.Classes.Children_Classes
{
    [Serializable]
    internal class Pistol: Parent_Classes.Firearm
    {
        public string Type { get; set; }
        public Pistol(string manufactured, string owner, int weight, string material, float caliber, string type)
        {
            this.Manufacturer = manufactured;
            this.Owner = owner;
            this.Weight = weight;
            this.Material = material;
            this.Caliber = caliber;
            this.Type = type;
        }

        public Pistol() { }
    }
}
