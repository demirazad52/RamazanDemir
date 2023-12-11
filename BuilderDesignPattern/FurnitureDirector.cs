using System;
namespace BuilderDesignPattern
{
    public class FurnitureDirector
    {
        public void Construct(IFurnitureBuilder builder){

            builder.BuildLegs();

            builder.BuildSeat();

            builder.BuildBackrest();
        }
    }


}

