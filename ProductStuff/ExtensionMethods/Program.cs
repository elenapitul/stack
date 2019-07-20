using System;
using System.Linq;

namespace ExtensionMethods
{
    internal class Dog
    {
        public string Name { get; internal set; }
        public int Age { get; internal set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToHalfHour());
            var nextHour = new DateTime(2019, 06, 22, 13, 46, 00);
            Console.WriteLine($"{nextHour} will be {nextHour.ToHalfHour()}");

            var half = new DateTime(2019, 06, 22, 13, 20, 00);
            Console.WriteLine($"{half} will be {half.ToHalfHour()}");

            //lambda
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int even = numbers.Count(x => x % 2 == 0);

            var odds = numbers.Select(x => x % 2 == 0);

            var odds2 = numbers.Where(x => x % 2 == 0).Select(x => x);



            var dogs = new Dog[]
                {
                new Dog { Name = "Spot", Age = 8 },
                new Dog { Name = "Rex", Age = 4 },
                new Dog { Name = "Skip", Age = 1 },
                new Dog { Name = "Lucky", Age = 3 }
                };

            var agePlus2 = dogs.Select(x => new
            {
                IncreasedAge = x.Age + 2
            });

            agePlus2.Select(x => x.IncreasedAge);

            var sortedDogs = dogs.OrderBy(d => d.Age);
            foreach (var dog in sortedDogs)
            {
                Console.WriteLine("{0} -> {1}", dog.Name, dog.Age);
            }



        }
    }
}
