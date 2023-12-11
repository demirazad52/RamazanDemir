using System;
namespace FactoryMethodDesignPattern
{
    public class ClothingFactory : ProductFactory
    {
        private string type;
        private string size;

        public ClothingFactory(string type, string size)
        {
            this.type = type;
            this.size = size;
        }

        public override IProduct CreateProduct()
        {
            return new Clothing(type, size);
        }
    }

}

