using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11_UML
{
    class MagicUser:GameCharacter
    {
        //1.field
        //2.properties
        //3.Method
        private int magicPower;


        public int MagicPower { get; set; }

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Magic Power: {MagicPower}");

        }

        
    }
}
