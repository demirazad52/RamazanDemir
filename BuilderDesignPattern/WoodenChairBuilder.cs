using System;
using BuilderDesignPattern;

namespace FactoryMethodDesignPattern
{
    public class WoodenChairBuilder : IFurnitureBuilder
    {
        private Furniture chair = new Furniture("wooden chair")
        public void BuildLegs()
        {
            chair.AddPart("wooden Legs");




        }

        public void BuildSeat()
        {
            chair.AddPart("Woden saet");


        }

        public void BuildBackrest()
        {




            chair.AddPart("Wooden backrest");
        }

        public Furniture GetFurniture()
        {
            return chair;
        }
    }



}

