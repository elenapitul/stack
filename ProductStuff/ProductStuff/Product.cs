using System;
using System.Collections.Generic;
using System.Text;

namespace ProductStuff
{
    public enum ProductType
    {
        Vegetables,
        Drinks,
        Dairy
    }
    public class Product
    {
        public static int Count = 0;
        //proprieties
        public const string MeasureUnit = "grams";

        public readonly string name;
        //sau private string name;
        public string Name
        {
            get
            {
                return name;
            }            
        }

        //public string Name
        //{
        //    get ;
        //    private set;
        //    //sau without set, for readonly
        //}
       

        public decimal Weight { get; }
        public decimal Price { get; }
        public DateTime ProductionDate { get; }
        public ProductType Type { get; }

        //mandatory - constructor
        public Product(string name, decimal weight, ProductType type, decimal price, DateTime productionDate)
        {
            //asignare

            //asign pe field-ul name, primul name e cel din private
            this.name = name;
            Weight = weight;
            Type = type;
            Price = price;
            ProductionDate = productionDate;
            Count++;
        }

        public DateTime ExpirationDate
        {
            get
            {
                if (Type == ProductType.Dairy)
                {
                    return ProductionDate.AddDays(7);
                }

                if (Type == ProductType.Drinks)
                {
                    return ProductionDate.AddYears(2);
                }
                                
                return ProductionDate.AddDays(3);
            }

        }

    }
}
