using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Based
{
    public class Weapon
    {
        public Weapon(string name, WeaponType type, string ammoSize, int ammoCount)
        {
            Name = name;
            Type = type;
            AmmoSize = ammoSize;
            AmmoCount = ammoCount;
        }

        public string Name { get; }

        public WeaponType Type { get; }

        public string AmmoSize { get; }

        public int AmmoCount { get; set; }
    }
}
