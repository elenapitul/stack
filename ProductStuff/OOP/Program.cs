using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Beagle myBeagle = new Beagle("Pisic", "runs");
            myBeagle.Hunt();

            Dog myCoolDog = new Beagle("patrocle", "runs as a dog");
            myCoolDog.Bark();

            Dog castedDog = (Dog)myBeagle;

            myBeagle.PlayWithBall();
            myBeagle.DoABarrelRoll();

            var myChild = new Child();
            myChild.PlayWithBall();

            myBeagle.Bark();
            
        }
    }
}
