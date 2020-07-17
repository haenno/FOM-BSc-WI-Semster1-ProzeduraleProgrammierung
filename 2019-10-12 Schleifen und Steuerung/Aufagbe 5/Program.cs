using System;

namespace Aufagbe_5
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
                float geradecheck = Convert.ToSingle(startzahl) / 2;

                if (geradecheck == (startzahl / 2))
                {
                    Console.WriteLine(startzahl);
                }
                startzahl++;
                
            }

            Console.WriteLine("\n\nAusgabe über For-Schleife:");
            for (int szf = 1; szf <= eingabe; szf++)
            {
                              
                float geradecheck = Convert.ToSingle(szf) / 2;
                             
                if (geradecheck == (szf/2))
                {
                    Console.WriteLine(szf);
                }
                
            }
            
            
            // Musterlösungen aus Vorlesung

            Console.WriteLine("\n\nMUSTER Ausgabe über For-Schleife:");
            for (int szf =0; szf <= eingabe; szf+=2)
            {
                    Console.WriteLine(szf);

            }

            Console.WriteLine("\n\nMUSTER Ausgabe über While-Schleife:");
            startzahl = 1;
            while (startzahl <= eingabe)
            {
                 if (startzahl % 2 == 0)
                {
                    Console.WriteLine(startzahl);
                }
                startzahl++;

            }


        }
    }
}
