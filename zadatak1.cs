using System;

namespace Zamjenarazmaka
{
    class Program
    {
        static void Main(string[] args)
            
        {
            
            Console.WriteLine("Unesite rečenicu:");
            
            string recenica = Console.ReadLine();

            string zamijenjenaRecenica = recenica.Replace(" ", "_");

            Console.WriteLine("Rečenica s zamijenjenim razmacima:");
            
            Console.WriteLine(zamijenjenaRecenica);
        }
    }
}
