using System;
using System.Collections.Generic;
using System.IO;


namespace TextReader_FileStream_complete
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
			bool exit = false; // <= exit dient hier als Schalter
			while (!exit)
			{
				for (int i = 0; i < blockSize; i++)
				{
					// Leseversuch
					string line = sr.ReadLine();

					if (line != null)
					{
						Console.WriteLine(line);
					}
					else
					{
						// Es gibt nichts mehr zu lesen, daher beenden!
						sr.Close();
						exit = true;
						break; // <= break beendet die aktuelle Schleife
					}
				}
				Console.ReadLine();
			}
		}
	}
}
