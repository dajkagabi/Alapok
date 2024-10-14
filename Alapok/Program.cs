using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            double price = 19.99;
            float myNumber = 3.14f;
            bool isActive = true;
            char letter = 'G';
            string name = "Gabriella";


            Console.WriteLine($" Age: {age},\n Price: {price},\n myNumber: {myNumber}, \n Active: {isActive}, \n Letter: {letter},\n Name: {name}, \n");

            //Operátorok
            int a = 10;
            int b = 3;
            int sum = a + b;
            int diff = a - b;
            int product = a * b;
            double quotient = (double)a / b;
            int remainder = a % b;
            bool isEqual = a == b;

            Console.WriteLine($" Sum: {sum}, \n Diff: {diff}, \n Product: {product}, \n Quotient: {quotient}, \n Remainder: {remainder}, \n isEqual: {isEqual} \n");

            //Egyszerű kérés
            Console.Write("Kérlek, írd be a neved:  ");
            string names = Console.ReadLine();
            Console.WriteLine($"Szia, {names}!");


            //Feltételes

            int ages = 17;
            if (ages > 18)
            {
                Console.WriteLine("Te már felnőtt vagy.");
            }
            else
            {
                Console.WriteLine("Te még nem vagy felnőtt.");
            }



            int myage = 24;

            if (myage < 18)
            {
                Console.WriteLine("Gyermek");
            }
            else if (myage < 65 )
            {
                Console.WriteLine("Középkorú");
            }
            else
            {
                Console.WriteLine("Nyugdíjas");
            }

            //Kedvezmény jár-e a felhasználónak?
            int kor = 12;
            if (kor < 14 ||  kor >= 65)
            {
                Console.WriteLine("A felhasználó jogosult kedvezményre.");
            }
            else
            {
                Console.WriteLine("A felhasználó nem jogosult kedvezményre.");
            }

            //Ciklusok

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"A for ciklus száma: {i}");
            }

            //Addig fut amíg a feltétel igaz

            int t = 1;

            while (t < 5)
            {
                Console.WriteLine($"A while ciklus száma: {t}");
                t++;
            }



            }
        }
    }