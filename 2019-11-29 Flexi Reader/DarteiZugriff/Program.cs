using System;
using System.Collections.Generic;
using System.IO;

namespace TextReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datei einlesen
            Console.Write("Bitte den Pfad zu einer Datei eingeben: ");
            string path = Console.ReadLine();
            FileStream fs = File.OpenRead(path);
            StreamReader sr = new StreamReader(fs);

            Console.Write("Wie viele Zeilen sollen jeweils dargestellt werden? ");
            int blockSize = Convert.ToInt32(Console.ReadLine());

            // Nun werden die Blöcke nacheinander ausgegeben
            bool readingLines = true;
            while (readingLines) // <== Wie kann diese Schleife vervollständigt werden?
            {
                for (int i = 0; i < blockSize; i++)
                {
                    string line = sr.ReadLine();

                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                    else
                    {
                        sr.Close();
                        i = blockSize;
                        readingLines = false;
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
