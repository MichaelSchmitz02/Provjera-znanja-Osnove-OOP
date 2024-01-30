using System;


class Program

{
    static void Main()

    {

        Console.Write("Unesite decimalni, cijeli broj i broj odvojeni razmakom: ");

        string unos = Console.ReadLine();


        string[] dijelovi = unos.Split(' ');


        if (dijelovi.Length == 2 && int.TryParse(dijelovi[0], out int cijelibroj) && double.TryParse(dijelovi[1], out double decimalnibroj))

        {

            Console.WriteLine("Unesenite cijeli broj: " + cijelibroj);
            Console.WriteLine("Unesenite decimalni broj: " + decimalnibroj);

        }
        else
        {

            Console.WriteLine("Netocan unos. Unesite ispravne vrijednosti.");

        }
    }
}
