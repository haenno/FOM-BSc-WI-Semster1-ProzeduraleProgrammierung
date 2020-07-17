using System;

namespace Aufgabe_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vorlesung 28.09.2019, Aufgabe 4\n\n\n" +
                "Geben Sie in folge drei Wörter ein...");
            string wort1 = Console.ReadLine();
            string wort2 = Console.ReadLine();
            string wort3 = Console.ReadLine();

            Console.WriteLine("Danke.\n\nHier kommt Wortsalat: \n" + wort3 + " " + wort2 + " " + wort1);
               

        }
    }
}
