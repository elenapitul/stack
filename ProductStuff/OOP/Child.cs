using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Child : IPlay
    {
        public void PlayWithBall()
        {
            Console.WriteLine("I am a child and I play with the ball");
        }
    }
}
