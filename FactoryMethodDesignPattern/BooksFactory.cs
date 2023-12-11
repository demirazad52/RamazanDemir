using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace FactoryMethodDesignPattern
{
    public class BooksFactory : ProductFactory
    {
        private string title;
        private string author;

        public BooksFactory(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public override IProduct CreateProduct()
        {
            return new Books(title, author);
        }
    }

}

