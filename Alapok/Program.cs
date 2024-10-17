using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
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

            Console.WriteLine("Adj meg egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());


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
                Console.WriteLine("Fiatal");
            }
            else if (myage < 65)
            {
                Console.WriteLine("Középkorú");
            }
            else
            {
                Console.WriteLine("Nyugdíjas");
            }

            //Kedvezmény jár-e a felhasználónak?
            int kor = 12;
            if (kor < 14 || kor >= 65)
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

            //For ciklus szöveg
            Console.WriteLine("Adj meg egy szöveget: ");
            string szoveg = Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{i + 1}.{szoveg}");
            }


            //Elől tesztelő, a feltétel ellenőrzése előtt hajtódik végre. Ha a feltétel hamis, nem fut le a ciklus.

            int t = 1;

            while (t < 5)
            {
                Console.WriteLine($"A while ciklus száma: {t}");
                t++;
            }

            //A feltétel ellenőrzése után hajtódik végre. A ciklus legalább egyszer mindig végrehajtódik, függetlenül a feltétel állapotától.
            int z = 0;
            do
            {
                Console.WriteLine($"A do-while ciklus: {z}");
                z++;
            } while (z < 5);

            //Miden elemen egyszer végrehajtódik.
            string[] cars = { "Opel", "Skoda", "Audi", "Lada" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            

            //Lista
            List<string> fruits = new List<string>();
            

            // Elemek hozzáadása a listához
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Cherry");

            // Lista kiíratása
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }





            //Tömbök
            string[] autok = { "Volvo", "Ford", "Mazda", "Mustang", "Audi", };

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
            foreach (string gyumolcs in gyumolcsok)
            {
                Console.WriteLine(gyumolcs);
            }

            //Random
            Random random = new Random();
            int vszm = random.Next(0, 50);
            Console.WriteLine($"Random szám: {vszm}");



            int[] numbers = new int[5];
            Random random1 = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 99);
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Mátrix (2x2 most)
            int[,] matrix = new int[2, 2];

            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1, 0] = 3;
            matrix[1, 1] = 4;



            Console.WriteLine("Kétdimenziós tömb (mátrix): ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //függvényy
            void greetings(string myname)
            {
                Console.WriteLine("Hello, " + myname + "!");
            }
            greetings("Gabriella");

            //Osztály

            // Car példányok létrehozása
            Car car1 = new Car("Corolla", "Toyota", 2020);
            Car car2 = new Car("Civic", "Honda", 2019);

            // Autók információinak kiírása
            car1.Info();
            car2.Info();

            // Fájl írása
            string filepath = "example.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    writer.WriteLine("Hello C#");
                    writer.WriteLine("Hello C#");
                    writer.WriteLine("Hello C#");
                }
                Console.WriteLine($"A fájl írása befejeződött: {filepath}");
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("Hiba történt a fájl írása során:");
                Console.WriteLine(ioEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Egy váratlan hiba történt:");
                Console.WriteLine(ex.Message);
            }

            // Olvasás a fájlból
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    Console.WriteLine("A fájl tartalma: ");
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException fnfEx)
            {
                Console.WriteLine("A fájl nem található:");
                Console.WriteLine(fnfEx.Message);
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("Hiba történt a fájl olvasása során:");
                Console.WriteLine(ioEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Egy váratlan hiba történt:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
