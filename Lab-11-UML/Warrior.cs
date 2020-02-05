using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_UML
{
    class Warrior: GameCharacter
    {
        //feild
        string primaryWeapon;
        //properties
        string PrimaryWeapon { get; set; }
        //constructors
        public Warrior(string _name, int _strength, int _intelligence, string _primaryWeapon)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            PrimaryWeapon = _primaryWeapon;
        }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Primary Weapon: {PrimaryWeapon}");

        }
    }
}
