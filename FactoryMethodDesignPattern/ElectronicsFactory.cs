using System;
namespace FactoryMethodDesignPattern
{
    public class ElectronicsFactory : ProductFactory
    {
        private string name;
        private double price;

        public ElectronicsFactory(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override IProduct CreateProduct()
        {
            return new Electronics(name, p,rice);
        }
    }

}
