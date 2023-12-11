using System;
namespace BuilderDesignPattern
{
    public class GlassTableBuilder : IFurnitureBuilder
    {
        private Furniture table = new Furniture("Glass Table");

        public void BuildLegs()
        {
            table.AddPart("Metal Legs");
        }

        

        public Furniture GetFurniture()
        {
            return table;
        }
    }


}

