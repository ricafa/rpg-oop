using System;
using rpg_oop.src.Entities;

namespace rpg_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Hero("Arus", 23, "Knight");
            Wizard mago = new Wizard("Jennica", 23, "White Wizard");
            Console.WriteLine(arus);
            Console.WriteLine(mago);
            Console.WriteLine("");
            Console.WriteLine(arus.attack());
            Console.WriteLine("");
            Console.WriteLine(mago.attack());
        }
    }
}
