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
            Console.WriteLine(mago);
            Console.WriteLine(mago.attack(1));
            Console.WriteLine(mago.attack(7));
        }
    }
}
