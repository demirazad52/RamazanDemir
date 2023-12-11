using System;
using 
namespace BuilderDesignPattern
{

    public interface IFurnitureBuilder
    {
        void BuildLegs();

        void BuildSeat();


        Furniture GetFurniture();
    }


}

