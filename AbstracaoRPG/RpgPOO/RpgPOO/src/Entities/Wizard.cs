using System;
using System.Collections.Generic;
using System.Text;

namespace RpgPOO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " Lançou Magia super efetiva com Bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia com Bonus de " + Bonus;
            }
           
        }
    }
}
