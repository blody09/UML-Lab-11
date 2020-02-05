using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_UML
{
    class Wizard: MagicUser
    {
        //1.field
        //2.properties
        //3.Method
        int spellCount;
        int SpellCount { get; set; }

        public Wizard(string _name, int _strength, int _intelligence, int _magicPower, int _spellCount)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicPower = _magicPower;
            SpellCount = _strength;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Spell Count: {SpellCount}");
            
        }
    }
}
