using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    public class Car
    {
        // Tulajdonságok
        public string Model { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        // Konstruktor
        public Car(string model, string name, int year)
        {
            Model = model;
            Name = name;
            Year = year;
        }

        // Metódus az autó információinak kiírására
        public void Info()
        {
            Console.WriteLine($"Car: {Model} {Name}, Year: {Year}");
        }
    }
}