using System;
using System.IO;
using System.Collections.Generic;

namespace _10_Zeiler_Rückwärts
{

    class Program
    {
        static void uberschriftZeichnen (string zeile)
        {
            int breiteFenster   = Console.BufferWidth;
            int laengeText = zeile.Length;
            int aktZeile = Console.CursorTop;
            int startpunktAusgabe = (breiteFenster / 2) - (laengeText / 2);
            Console.SetCursorPosition(startpunktAusgabe, aktZeile);
            Console.Write(zeile);
            Console.SetCursorPosition(0, aktZeile + 1);
        }


        static void Main(string[] args)
        {
            while (true)
            {

                uberschriftZeichnen(">Ultra-10-Zeilen-Leser-3.000<");
                uberschriftZeichnen("-----------------------------");
                uberschriftZeichnen("v.2.0: mit Reverse!!11einself");


                Console.Write("\nBitte Dateipfad und -name angeben:   ");
                string path = Console.ReadLine();
               

                if (File.Exists(path)) 
                {
                    int anzZeilenAusgabe;
                    bool zeilenEingabeGelungen = false;
                    do
                    {
                        Console.Write("\nWie viele Zeilen sollen pro Block ausgegeben werden?   ");
                        string anzZeilenAusgabeStr = Console.ReadLine();
                        zeilenEingabeGelungen = Int32.TryParse(anzZeilenAusgabeStr, out anzZeilenAusgabe); 

                    } while (!zeilenEingabeGelungen);



                    Console.WriteLine("\n");


                    List<string> dateiInhalt = new List<string>(File.ReadAllLines(path));

                    int ausgabeZaehler = 0;
                    for (int i = 0; i < dateiInhalt.Count; i++)
                    {
                    
                        if (ausgabeZaehler != anzZeilenAusgabe)
                        {
                            Console.WriteLine(dateiInhalt[i]);
                            ausgabeZaehler++;
                        }
                        else
                        {
                            ausgabeZaehler = 0;
                            i--;
                            Console.WriteLine("\nWeiter mit Enter..."); Console.ReadLine();
                        }
                    }
                    Console.WriteLine("\n\nDateiende erreicht. Ausgabe nun in umgekehrter Reihenfolge...\n"); Console.ReadLine();

                    ausgabeZaehler = 0;
                    for (int i = dateiInhalt.Count; i >0; i--)
                    {
                        if (ausgabeZaehler != anzZeilenAusgabe)
                        {
                            Console.WriteLine(dateiInhalt[i-1]);
                            ausgabeZaehler++;
                        }
                        else
                        {
                            ausgabeZaehler = 0;
                            i++;
                            Console.WriteLine("\nWeiter mit Enter..."); Console.ReadLine();
                        }
                    }

                    Console.WriteLine("\n\nDateiende erreicht. Neustart mit Enter..."); Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Datei existiert nicht! Neustart mit Enter... "); Console.ReadLine();
                }
                Console.Clear();
            }

        }
    }
}
