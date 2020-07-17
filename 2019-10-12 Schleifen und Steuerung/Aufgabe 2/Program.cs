using System;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe = 0;

            do
            {
                Console.Write("Bitte gib eine Zahl zwischen 1 und 12 ein: ");
                eingabe = Convert.ToInt32(Console.ReadLine());
                string monat = "Dieser Monat hat ";
                switch (eingabe)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        { monat = monat + "31 Tage!"; break; }

                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        { monat = monat + "30 Tage!"; break; }

                    case 2: { monat = monat + "28 Tage! (außer es ist ein Schaltjahr, dann 29 Tage!)"; break; }
                    default: { monat = "Ungültige Eingabe. Bitte Wiederholen!"; eingabe = 13; break; }
                }
                Console.WriteLine(monat);
            } while (eingabe == 13);
        }
    }
}
