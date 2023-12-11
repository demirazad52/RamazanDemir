using System;


namespace BuilderDesignPattern
{

    class Program
    {
        static void Main(string[] args)
        {
            var director = new FurnitureDirector();


            var woodenChairBuilder = new WoodenChairBuilder();

            director.Construct(woodenChairBuilder);
            var chair = woodenChairBuilder.GetFurniture();
            chair.DisplayInfo();




            var glassTableBuilder = new GlassTableBuilder();
            director.Construct(glassTableBuilder);

            var table = glassTableBuilder.GetFurniture();

            table.DisplayInfo();





            var metalCabinetBuilder = new MetalCabinetBuilder();
            director.Construct(metalCabinetBuilder);

            var cabinet = metalCabinetBuilder.GetFurniture();




            cabinet.DisplayInfo();
        }
    }

}