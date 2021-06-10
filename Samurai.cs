using System;
namespace WizardNinjaSamurai
{
    //Samurai should have a default health of 200
    public class Samurai : Human
    {

        public Samurai(string name) : base(name)
        {
            Health = 200;
        }

        //Samurai should have a method called Meditate, which when invoked, heals the Samurai back to full health
        public void Meditate()
        {
            Health = 200;
            Console.WriteLine($"{Name} has recovered by 200");
        }

        /*
            Provide an override Attack method to Samurai, which calls the base Attack and reduces the 
            target to 0 if it has less than 50 remaining health points.
        */
        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.Health < 50)
            {
                target.Health = 0;
            }
            return target.Health;
        }
    }
}