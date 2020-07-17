using System;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float literpreis = 1.319f;

            Console.WriteLine("Vorlesung 28.09.2019, Aufgabe 6\n\n\n" +
               "Danke fürs Tanken! Der Sprit kostet heute " + literpreis + " Euro/Liter. Wie viel Liter waren es denn?");

            float menge = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Oh, das war viel! Haben Sie eine Kundenkarte? [geben Sie bitte 'Ja' oder 'Nein' ein!]");
            string kundenkarte = Console.ReadLine();
                         

            if (kundenkarte=="Ja")
            {
                literpreis = literpreis *0.98f;
                Console.WriteLine("Danke, dass Sie uns treu sind!");
            }
            else if (kundenkarte=="Nein")
            {
                Console.WriteLine("Okay! Ihnen entgehen tolle Vorteile... aber das ist Ihre Entscheidung.");
            }
            else
            {
                Console.WriteLine("Ich konnte Sie nicht verstehen. Ein Rabatt konnte nicht berücksichtigt werden.");
            }

            Console.WriteLine("Der Sprit kostet heute für Sie " + literpreis + " Euro/Liter. Bitte zahlen Sie " + Math.Round((menge * literpreis),2) + " Euro!");



                
        }
    }
}
