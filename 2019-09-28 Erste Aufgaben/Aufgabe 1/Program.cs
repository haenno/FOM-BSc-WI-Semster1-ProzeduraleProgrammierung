using System;

namespace Aufgabe_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Aufgabe 1\n\nGib bitte die Erste von zwei Zahlen ein: ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Nun die Zweite: ");
            float b = Convert.ToSingle(Console.ReadLine());

            if (b!=0)
            { 
            float rausdamit = a + b;
            Console.Write("\nErgebnisse:\n***********\n\nAddition:       " + rausdamit + "\n");

            rausdamit = a * b;
            Console.Write("Multiplikation: " + rausdamit + "\n");

            rausdamit = a - b;
            Console.Write("Subtraktion:    " + rausdamit + "\n");

            rausdamit = a / b;
            Console.Write("Division:       " + rausdamit + "\n\n\n");
            }
            else { Console.WriteLine("Die 2. Zahl darf nicht 0 sein!"); }
        }
    }
}
