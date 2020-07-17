using System;
using System.IO;
using System.Collections.Generic;

namespace Vorlesung_22._11._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.Write("Ultra-10-Zeilen-Leser-3000\n\nBitte Dateipfad und -name angeben:   ");
            string path = Console.ReadLine();

            
                List<string> dateiInhalt = new List<string>(File.ReadAllLines(path));

                int ausgabeZaehler = 0;
                for (int i = 0; i < dateiInhalt.Count; i++)
                {
                    if (ausgabeZaehler != 10) 
                    {
                        Console.WriteLine(dateiInhalt[i]);
                        ausgabeZaehler++;
                    }
                    else
                    {
                        ausgabeZaehler = 0;
                        i--;

                        Console.WriteLine("\nWeiter mit Enter..."); Console.ReadLine();


                        //Abfrage nach NUR ENTER Taste! (kaputt)
                        /*
                        do
                        {
                            Console.WriteLine("\nWeiter mit Enter-Taste...");

                            string nurEnter = Convert.ToString(Console.ReadKey());

                            Console.WriteLine(nurEnter);
                            Console.WriteLine(Convert.ToString(ConsoleKey.Enter));

                            if (nurEnter == Convert.ToString(ConsoleKey.Enter))
                            {
                                Console.WriteLine("yay");
                                break;
                            }

                        } while (true);
                        */
                        



                    }
                }
                Console.WriteLine("\n\nDateiende erreicht. Neustart mit ANYKEY."); Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
