using System;

namespace Lab_11_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] heroes = new GameCharacter[]
            {
                new Wizard("Gandalf",10,9,9,10),
                new Wizard("Walter Padick",8,9,9,9),
                new Wizard("Triss Merigold",10,10,9,9),
                new Warrior("Link",20,6,"Mastersword"),
                new Warrior("Dirty Harry",15,6,".44 Magnum"),
            };


            foreach (var hero in heroes)
            {
                hero.Play();
                Console.WriteLine();
            }
        }
    }
}
