using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Ninja ninja1 = new Ninja("Ninja");
            Wizard wizard1 = new Wizard("Wizard");
            Samurai samurai1 = new Samurai("Samurai");
            Human human1 = new Human("Nardos");

            ninja1.Attack(human1);
            ninja1.Steal(human1);
            wizard1.Attack(ninja1);
        }
    }
}
