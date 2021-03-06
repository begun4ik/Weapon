﻿using System;

namespace Weapon.Classes.Parent_Classes
{
    [Serializable]
    public abstract class Weapon
    {
        public string Manufacturer { get; set; }
        public string Owner { get; set; }
        public int Weight { get; set; }
        public string Material { get; set; }
        public string Name { get; set; }
    }
}
