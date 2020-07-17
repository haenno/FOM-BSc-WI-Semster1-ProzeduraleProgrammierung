using System;
using System.Threading;
using System.Collections.Generic;

namespace Vorlesung_2020_01_18 
{
    class Program
    {

        

        //Countdown einer eingegebenen Zahl
        public static void countdown()
        {
            Console.Write("Gib 1 Ganzzahl ein: ");
            int Eingabe = Convert.ToInt32(Console.ReadLine());

            for (; Eingabe>-1;Eingabe--)
            {
                Console.WriteLine(Eingabe);
            }
            return;
        }




        // Ändern weg von Eingabe zu übergabe + Pausen bei Ausgabe
        public static void countdownV2(int Zahl)
        {
            for (; Zahl >-1; Zahl--)
            {
                Console.WriteLine(Zahl);
                Thread.Sleep(1000);
                
            }
            return;
        }






        public static void ZahlRaten()
        {
            Random rndGen = new Random();
            int rnd = rndGen.Next(1, 100);

            Console.Write("Gib eine Ganzzahl zwichen 1 und 100 ein:");
            int Eingabe = Convert.ToInt32(Console.ReadLine());

            string Ausgabe = "stimmt!";

            if      (Eingabe < rnd) { Ausgabe = "zu klein!";  }
            else if (Eingabe > rnd) { Ausgabe = "zu groß!";   }

            Console.WriteLine("Deine Antwort war: " + Ausgabe);

            return;
        }




        public static void ZahlAnnaehrn()
        {
            Random rndGen = new Random();
            int rnd = rndGen.Next(1, 100);
            int Eingabe;

            bool geraten = false; 

            do
            {
                Console.Write("Gib eine Ganzzahl zwichen 1 und 100 ein:");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                
                string Ausgabe = "stimmt!";

                if (Eingabe < rnd) { Ausgabe = "zu klein!"; }
                else if (Eingabe > rnd) { Ausgabe = "zu groß!"; }

                Console.WriteLine("Deine Antwort war: " + Ausgabe);

                // if (rnd == Eingabe) { geraten = true; }
                geraten = rnd == Eingabe;


            } while (!geraten);
            Console.Clear();

            return;
        }




        public static double kreisFlaeche(double radius)
        {
            return Math.Pow(radius,2) * Math.PI;
        }

        public static void kreisRechnerCli()
        {
            Console.Write("Gib einen Radius ein: ");
            double KreisFL = kreisFlaeche(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Die Kreisfläche ist " + KreisFL);
        }


       
        public static bool checkNumbers(int a, int b, List<int> l)
        {
            foreach (int n in l)
            {
                if (a > n || b < n)
                {
                    return false;
                }
            }
            return true;
        }


        public static void skriptSeite87()
        {
            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(19);
            numbers.Add(-5);
            numbers.Add(3);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("i=" + i + " numbers=" + numbers[i] + " numbers.Count=" + numbers.Count);

            }
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            while (true)
            {
                //countdown();
                //countdownV2(1);
                //ZahlRaten();
                //ZahlAnnaehrn();

                //kreisRechnerCli();

                //List<int> zlist = new List<int>();

                //bool passt = checkNumbers(1, 10, zlist);

                skriptSeite87();

            }
        }
        }
    }
