using System;


public class KlasaX
{

    private int broj;


    public int Broj
    {

        get { return broj; }
        set { broj = value; }
    }

}

public class KlasaY : KlasaX

{

}

public class Program

{
    public static void Main(string[] args)
    {

        KlasaY y = new KlasaY();

        y.Broj = 10;

        Console.WriteLine("Vrijednost varijable broj: " + y.Broj);
    }
}

