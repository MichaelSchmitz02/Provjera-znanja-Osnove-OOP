using System;

namespace Sortiranjestringova
{
    class Program

    {
        static void Main()

        {
            Console.WriteLine("Unesite prvu rijec:");

            string prviString = Console.ReadLine();

            Console.WriteLine("Unesite drugu rijec:");

            string drugiString = Console.ReadLine();

            string[] stringovi = { prviString, drugiString };

            array.Sort(stringovi);

            Console.WriteLine("Sortirani rijeci:");

            foreach (string s in stringovi)
            {
                Console.WriteLine(s);
            }
        }
    }
}
