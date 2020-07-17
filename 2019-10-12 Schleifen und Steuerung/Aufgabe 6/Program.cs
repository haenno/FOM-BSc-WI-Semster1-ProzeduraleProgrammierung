using System;

namespace Aufgabe_6
{
    class Program
    {
        static void Main(string[] args)
        {        
            int az = 0;
            int azhelper = 0;
            string qz ="" ;
            while (qz.Length <= 4)
            {
                azhelper = az * az;
                Console.WriteLine(az + " x " + az + " = " + azhelper);
                qz = Convert.ToString(azhelper);
                az++;
            }
            Console.WriteLine("\n\nErste 5-stellige Quadratzahl gefunden: " + qz);
        }
    }
}
