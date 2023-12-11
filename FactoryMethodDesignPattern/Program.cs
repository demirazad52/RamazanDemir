using FactoryMethodDesignPattern;

namespace FactoryMethodDesignPattern {

class Program
{
    static void Main(string[] args)
    {
        ProductFactory electronicsFactory = new ElectronicsFactory("iphone 15 Pro max is ",1240);
        var electronics = electronicsFactory.CreateProduct();
        electronics.DisplayInformation();

        ProductFactory clothingFactory = new ClothingFactory("sweetshirt", "M");
        var clothing = clothingFactory.CreateProduct();
        clothing.DisplayInformation();

        ProductFactory booksFactory = new BooksFactory("1984", "George orwell");
        var book = booksFactory.CreateProduct();
        book.DisplayInformation();
    }
}

}