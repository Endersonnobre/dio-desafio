using System;
using System.Collections.Generic;
using System.Text;

namespace RpgPOO.src.Entities
{
    public class Warrior : Hero
    {
        public Warrior(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
    }
}
