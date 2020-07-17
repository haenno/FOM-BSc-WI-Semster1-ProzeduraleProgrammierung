using System;
using System.Collections.Generic;

namespace Foreach_Übung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Einlesen
            bool EingabenLesen = true;
            List<string> Eingaben = new List<string>();
            while (EingabenLesen)
            {
                Console.Write("Bitte gib ein Wort ein:");
                string Eingabe = Console.ReadLine();
                if (Eingabe != "")
                {
                    Eingaben.Add(Eingabe);
                }
                else
                {
                    EingabenLesen = false;
                }
            }

            //Ausgeben
            Console.WriteLine("\n\nCompute *bbeeeep beep*\n\n");
            foreach(string Zeile in Eingaben)
            {
                Console.WriteLine(Zeile);
            }

        }
    }
}
