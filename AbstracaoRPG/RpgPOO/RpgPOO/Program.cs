using System;
using RpgPOO.src.Entities;

namespace RpgPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior hero = new Warrior("Arus", 12, "Warrior");
            Wizard enemy = new Wizard("Tenrio", 7, "Dark Priest");

            //Console.WriteLine($"Nome:{hero.Name}\nLevel:{hero.Level}\nClasse:{hero.HeroType}");
            Console.WriteLine(hero.Attack());
            Console.WriteLine(enemy.Attack(4));
       
        }
    }
}
