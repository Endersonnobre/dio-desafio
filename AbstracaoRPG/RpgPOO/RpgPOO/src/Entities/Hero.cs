using System;
using System.Collections.Generic;
using System.Text;

namespace RpgPOO.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero() 
        { 
        }
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }


        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a espada";
        }
    }
}
