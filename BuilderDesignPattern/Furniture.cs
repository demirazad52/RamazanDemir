using System;

namespace BuilderDesignPattern
{
    public class Furniture
    {
        public string Name { get; }
        private List<string> parts = new List<string>();

        public Furniture(string name)
        {
            Name = name;
        }

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Furniture: " + Name);
            foreach (var part in parts)
            {
                Console.WriteLine("  " + part);
            }
        }
    }


}

