using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_UML
{
    class GameCharacter
    {
        public String name;
        public int strength;
        private int intelligence;

        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }


        public virtual void Play()
        {
            Console.WriteLine($"Name: {Name} ");
            Console.WriteLine($"Str: {Strength}");
            Console.WriteLine($"Int: {Intelligence}");
        }
    }
}
