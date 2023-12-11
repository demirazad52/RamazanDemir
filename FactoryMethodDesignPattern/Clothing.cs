using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace FactoryMethodDesignPattern
{
    public class Clothing : IProduct
    {
        public string Type { get; set; }
        public string Size { get; set; }

        public Clothing(string type, string size)
        {
            Type = type;
            Size = size;
        }

        public void DisplayInformation()
        {
            Console.WriteLine("Clothing - Type: " + Type + "Size:" + Size);

        }
    }
    }


