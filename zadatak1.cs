using System;

namespace Zamjenarazmaka
{
    class Program
    {
        static void Main(string[] args)
            
        {
            
            Console.WriteLine("Unesite jednu recenicu:");
            
            string recenica = Console.ReadLine();

            string zamijenjenaRecenica = recenica.Replace(" ", "_");

            Console.WriteLine("Recenica sa zamijenjenim razmacima:");
            
            Console.WriteLine(zamijenjenaRecenica);
        }
    }
}
