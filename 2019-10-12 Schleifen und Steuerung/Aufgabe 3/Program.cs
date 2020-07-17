using System;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // voakle 8 stück: a e i o u ä ö ü
            string eingabe ="";

            do
            {
                Console.Write("Bitte gib einen Buchstaben ein: ");
                eingabe = Convert.ToString(Console.ReadLine());
                string buart= "Der Buchstabe ist ein ";
               if (eingabe.Length==1) {
                    eingabe = eingabe.ToLower();
                    switch (eingabe)
                    {
                        case "a":
                        case "e":
                        case "i":
                        case "o":
                        case "u":
                        case "ä":
                        case "ö":
                        case "ü":
                            { buart = buart + "Vokal!"; break; }
                    
                        case "b":
                        case "c":
                        case "d":
                        case "f":
                        case "g":
                        case "h":
                        case "j":
                        case "k":
                        case "l":
                        case "m":
                        case "n":
                        case "p":
                        case "q":
                        case "r":
                        case "s":
                        case "t":
                        case "v":
                        case "w":
                        case "x":
                        case "y":
                        case "z":
                            { buart = buart + "Konsonant!"; break; }

                        default: { buart = "Ungültige Eingabe. Bitte Wiederholen!"; eingabe = "13"; break; }
                    }
                } else 
                { 
                       buart = "Ungültige Eingabe. Bitte Wiederholen!"; eingabe = "13"; 
                }
                Console.WriteLine(buart);
            } while (eingabe == "13");
        }
    }
}
