using System;

namespace Aufgabe_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aufgabe 2\n\nGib bitte einen Radius an (Zahl größer 0): ");

            

            double radius = Convert.ToDouble(Console.ReadLine());

            if (radius > 0)
            {
                double umfang = Math.PI *2 * radius  ;
                double flaeche = (radius * radius) * Math.PI;
                Console.WriteLine("Umfang ist: " + umfang + " ...und die Fläche ist: " + flaeche);
            }
            else
            {
                Console.WriteLine("Du doof");
            }
        }
    }
}
