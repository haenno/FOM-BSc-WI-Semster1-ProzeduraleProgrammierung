using System;

namespace Aufgabe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vorlesung 28.09.2019, Aufgabe 5\n\n\n" +
               "Geben Sie in folge drei Zahlen ein...");
            float z1 = Convert.ToSingle(Console.ReadLine());
            float z2 = Convert.ToSingle(Console.ReadLine());
            float z3 = Convert.ToSingle(Console.ReadLine());


            Console.WriteLine("Sortiere...");

            // noch mal mit direkt ausgabe bei erfolgreicher abprüfung

            if ((z1 < z2) && (z1 < z3))
            {
                Console.WriteLine(z1);
                if (z2 < z3)
                {
                    Console.WriteLine(z2);
                    Console.WriteLine(z3);
                }
                else
                {
                    Console.WriteLine(z3);
                    Console.WriteLine(z2);
                }
            }
            else if ((z2 < z3) && (z2 < z1))
            {
                Console.WriteLine(z2);
                if (z1 < z3)
                {
                    Console.WriteLine(z1);
                    Console.WriteLine(z3);
                }
                else {
                    Console.WriteLine(z3);
                    Console.WriteLine(z1);
                }

            }
            else if ((z3 < z1) && (z3 < z1))
            {
                Console.WriteLine(z3);
                if (z1< z2)
                {
                    Console.WriteLine(z1);
                    Console.WriteLine(z2);
                }
                else
                {
                    Console.WriteLine(z2);
                    Console.WriteLine(z1);
                }

            }
            else
            { 
                Console.WriteLine("Error");
            }


            /* 
            float sz1 = 0;
            float sz2 = 0;
            float sz3 = 0;

            if ((z1>z2)&&(z1>z3))
            {
                sz3 = z1;
                if (z2>z3)
                {
                     sz2 = z3;
                     sz1 = z2;
                }
                else
                {
                     sz2 = z2;
                     sz1 = z3;

                }
            }
            else if ((z2>z1) && (z2>z3))
            {
                 sz3 = z2;
                if (z1 > z3)
                {
                     sz2 = z1;
                     sz1 = z3;
                }
                else
                {
                     sz2 = z3;
                     sz1 = z1;

                }
            } else
            {
                 sz3 = z3;
                if (z1 > z3)
                {
                     sz2 = z2;
                     sz1 = z1;
                }
                else
                {
                     sz2 = z1;
                     sz1 = z2
                        ;
                }
            }

            Console.WriteLine("Danke.\n\nHier kommen die Zahlen aufsteigend nach Größe sortiert: \n\n" + sz1 + " \n" + sz2 + "\n" + sz3);
            */
        }
    }
}
