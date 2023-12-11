using System;
namespace FactoryMethodDesignPattern
{
    public class Electronics : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Electronics(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Electronics Name: " + Name + ", Price: " + Price);





        }
    }

}

