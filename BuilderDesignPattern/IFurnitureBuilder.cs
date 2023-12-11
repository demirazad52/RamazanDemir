using System;

namespace BuilderDesignPattern
{

    public interface IFurnitureBuilder
    {
        void BuildLegs();

        void BuildSeat();


        Furniture GetFurniture();
    }


}

