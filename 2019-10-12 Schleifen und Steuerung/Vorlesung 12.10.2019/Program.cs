using System;

namespace Vorlesung_12._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
         

            int eingabe = 0;

            do
            {
                Console.Write("Bitte gib eine Zahl zwischen 1 und 7 ein: ");
                eingabe = Convert.ToInt32(Console.ReadLine());
                string wochentag = "Die Zahl entspricht dem Wochentag: ";
                switch (eingabe)
                {
                    case 1: { wochentag = wochentag + "Montag"; break; }
                    case 2: { wochentag = wochentag + "Dienstag"; break; }
                    case 3: { wochentag = wochentag + "Miitwoch"; break; }
                    case 4: { wochentag = wochentag + "Donnerstag"; break; }
                    case 5: { wochentag = wochentag + "Freitag"; break; }
                    case 6: { wochentag = wochentag + "Samstag"; break; }
                    case 7: { wochentag = wochentag + "Sonntag"; break; }
                    default: { wochentag = "Ungültige Eingabe. Bitte Wiederholen!"; eingabe = 13; break; }
                }
                Console.WriteLine(wochentag);
            } while (eingabe == 13);

        }
    }
}
