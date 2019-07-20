using System;

namespace ProductStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Product myProduct = new Product("rosie", 150, ProductType.Vegetables, 1, DateTime.Now);
            Product myProduct2 = new Product("rosie", 150, ProductType.Vegetables, 1, new DateTime(2018, 09, 19));
            Console.WriteLine(myProduct.Name);
            Console.WriteLine(myProduct.Name);
            
            //myProduct.name = "dovlecel";
            Console.WriteLine(Product.MeasureUnit);
            
            //Product.MeasureUnit = "liters";
            Console.WriteLine(myProduct.ProductionDate);
            Console.WriteLine(myProduct.ExpirationDate);
            Console.WriteLine(Product.Count);

            //anonymous types
            var point = new { X = 3, Y = 5 };

            var car = new
            {
                Color = "Blue",
                Speed = 100,
                Make = new
                {
                    Name = "Audi",
                    Year = 2015
                }
            };
            Console.WriteLine(car.Make.Name);

        }
    }
}
