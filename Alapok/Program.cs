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

            
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Hétfő");
                    break;
                case 2:
                    Console.WriteLine("Kedd");
                    break;
                case 3:
                    Console.WriteLine("Szerda");
                    break;
                case 4:
                    Console.WriteLine("Csütörtök");
                    break;
                case 5:
                    Console.WriteLine("Péntek");
                    break;
                case 6:
                    Console.WriteLine("Szombat");
                    break;
                case 7:
                    Console.WriteLine("Vasárnap");
                    break;
            }

            //Ciklusok

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"A for ciklus száma: {i}");
            }

            //Elől tesztelő, ha minden egyes feltétel teljesül.

            int t = 1;

            while (t < 5)
            {
                Console.WriteLine($"A while ciklus száma: {t}");
                t++;
            }

            //Hátul tesztelő, ciklusmag végrehajtása után megy végbe.
            int z = 0;
            do
            {
                Console.WriteLine($"A do-while ciklus: {z}");
                z++;
            }while (z < 5);

            //Miden elemén egyszer végrehajtódik.
            string[] cars = { "Opel", "Skoda", "Audi", "Lada" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            //Tömbök
            string[] autok = { "Volvo", "Ford", "Mazda", "Mustang", "Audi",  };

            Console.WriteLine($"Az autó: {autok[1]}");
            Console.WriteLine(autok.Length);

            Array.Sort(autok);

            Console.WriteLine("Rendezett autók:");
            foreach (string auto in autok)
            {
                Console.WriteLine(auto);
            }


            string[] gyumolcsok = { "banán", "alma", "cseresznye", "eper" };
        
            Array.Sort(gyumolcsok);
            Console.WriteLine("Rendezett gyümölcsök: ");
            foreach(string gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcs);
            }

            //Random
            Random random = new Random();
            int vszm = random.Next(0, 50);
            Console.WriteLine($"Random szám: {vszm}");



            int[] numbers = new int[10];
            Random random1 = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }



        }
      
    }
}