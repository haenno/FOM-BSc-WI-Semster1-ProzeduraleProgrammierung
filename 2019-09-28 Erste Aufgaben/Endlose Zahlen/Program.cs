using System;

namespace Endlose_Zahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gib Zahl: ");

            string eingabe = Console.ReadLine();
            Console.WriteLine(eingabe);

            float singleformat= Convert.ToSingle(eingabe);
            Console.WriteLine(singleformat);

            double doubleformat = Convert.ToDouble(eingabe);
            Console.WriteLine(doubleformat);


        }
    }
}
