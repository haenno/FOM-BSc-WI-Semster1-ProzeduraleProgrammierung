using System;
using System.IO;
using System.Collections.Generic;

 namespace Flexi_Reader //Variante mit Vor und Rücklauf...
{

    class Program
    {
        static void uberschriftZeichnen(string zeile)
        {
            int breiteFenster = Console.BufferWidth;
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
                for (int baum=0;baum<40;baum++) {
                    uberschriftZeichnen(new String('*', baum));
                }
				
				
                uberschriftZeichnen(">Ultra-10-Zeilen-Leser-9.000<");
                uberschriftZeichnen("-----------------------------");
                uberschriftZeichnen("v.3.0: mit Reverse!!11einself");


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
                        if (i < 0) { i = 0; }
                        Console.WriteLine(dateiInhalt[i]);
                        ausgabeZaehler++;


                        if (ausgabeZaehler == anzZeilenAusgabe)
                        {
                            Console.WriteLine("\nZeilen ausgegeben. Vorherigen Block anzeigen mit 'z', nächsten Block mit beliebiger Taste...");
                            string leserichtung = Console.ReadLine();
                            if (leserichtung=="z")
                            {
                                i = i - (anzZeilenAusgabe*2);
                            }
                            ausgabeZaehler = 0;

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
