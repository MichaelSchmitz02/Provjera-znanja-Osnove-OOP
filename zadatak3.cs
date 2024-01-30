using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite broj n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Neispravan unos. Molimo unesite prirodan broj veći od 0.");
            return;
        }

        long rezultat = FibonaccijevNiz(n);

        Console.WriteLine($"N-ti član Fibonaccijevog niza za n = {n} je: {rezultat}");
    }

    static long FibonaccijevNiz(int n)
    {
        if (n == 1) return 0;
        if (n == 2) return 1;

        long prethodni = 

