using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Dog
    {
        private string name;

        public Dog(string name)
        {
            Console.WriteLine("dog");
            this.name = name;
        }

        public virtual void Bark()
        {
            Console.WriteLine("Ham Ham");
        }
    }
}
