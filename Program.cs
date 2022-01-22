using System;
using rpg_oop.src.Entities;

namespace rpg_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard mago = new Wizard("Jennica", 23, "White Wizard");
            Console.WriteLine(arus);
            Console.WriteLine(mago);
            Console.WriteLine(arus.attack());
            Console.WriteLine(mago.attack(7));
        }
    }
}
