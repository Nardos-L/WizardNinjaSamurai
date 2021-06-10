using System;
namespace WizardNinjaSamurai
{
    //Wizard should have a default health of 50 and Intelligence of 25
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Health= 50;
            Intelligence = 25;
        }
        //Wizard should have a method called Heal, which when invoked, heals a target Human by 10 * Intelligence
        public int Heal(Human target){
            int healAmount = 10*Intelligence;
            target.Health += healAmount;
            Console.WriteLine($"{Name} has healed {target.Name} and restored {healAmount}");

            return target.Health;
        }

        /*Provide an override Attack method to Wizard, 
        which reduces the target by 5 * Intelligence and heals the Wizard by the amount of damage dealt
        */
        public override int Attack(Human target)
        {
            int dmg = Intelligence * 5;
            target.Health -= dmg;
            Health+= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
    }
}