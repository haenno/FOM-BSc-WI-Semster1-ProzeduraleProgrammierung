using System;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib eine Zahl ein: ");
            
            int eingabe = Convert.ToInt32(Console.ReadLine());
                               
                Console.WriteLine("\n\nAusgabe über While-Schleife:");
                int startzahl = 1;
                while (startzahl <= eingabe)
                {
                    Console.WriteLine(startzahl);
                    startzahl++;    
                }

                Console.WriteLine("\n\nAusgabe über For-Schleife:");
                for (int szf = 1; szf <= eingabe; szf++)
                {
                    Console.WriteLine(szf);
                }

            }
    }
}
