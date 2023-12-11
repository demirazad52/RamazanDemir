using System;
namespace FactoryMethodDesignPattern
{
    public class Books : IProduct
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Books(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Book Title: " + Title + "Author" + Author );
        }
    }

}

