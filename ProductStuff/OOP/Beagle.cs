using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Beagle : Dog, IPlay,IRollable
    {
        private string name;
        private string ability;
        
        //state, constructor
        public Beagle(string name, string ability) : base(name)
        {
            Console.WriteLine("beagle");
            this.name = name;
            this.ability = ability;
        }

        public void DoABarrelRoll()
        {
            Console.WriteLine("Do a barrel roll.");
        }

        //behaviour
        public void Hunt()
        {
            Console.WriteLine("Hunt");
        }

        public void PlayWithBall()
        {
            Console.WriteLine("I play with a ball on the grass.");
        }

        //method shadowing
        public override void Bark()
        {
            Console.WriteLine("I'm a beagle and I bark.");
        }
    }
}
