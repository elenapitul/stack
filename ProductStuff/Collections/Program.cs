using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)



        {
            List<int> myInts = new List<int>()
            {
                2,
                4,
                6,
                8
            };

            //foreach (var item in myInts)
            //{
            //    Console.WriteLine(item);
            //}

            var fileContent = File.ReadAllLines(@"C:\Users\APE\source\repos\ProductStuff\Collections\Numbers.txt");

            var elements = fileContent.Select(x => x).ToList();

            var oddelements = fileContent.Where(x => int.Parse(x) % 2 != 0).Select(x => x).ToList();
            var divideThree = fileContent.Where(x => int.Parse(x) % 3 == 0).ToList();

            foreach (var item in oddelements)
            {
                Console.WriteLine(item);
            }

            foreach (var item in divideThree)
            {
                Console.WriteLine(item);
            }

            Stack<int> myStack = new Stack<int>();
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);

            var length = myStack.Count;
            var top = myStack.Pop();
            length = myStack.Count;

            var lastElement = myStack.Peek();
            Console.WriteLine("Last element is " + lastElement);

            Stack <int> myReverse = new Stack<int>(myStack.Reverse());
            var topreverse = myReverse.Pop();
            Console.WriteLine("The topreverse element is " + topreverse);


            /*Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(2, "second item");
            myDictionary.Add(3, "third item");

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item.Key);
            }

            foreach (var item in myDictionary)
            {
                Console.WriteLine(item.Value);
            }

            if (myDictionary.Keys.Contains(2))
            {
                Console.WriteLine();
            }*/
        }
    }
}
