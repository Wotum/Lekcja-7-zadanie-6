using System;

namespace ZmyslonaKategoria;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Podaj swój wzrost (w centymetrach): ");

        if (int.TryParse(Console.ReadLine(), out int wzrost))
        {
            string kategoria = (wzrost < 150) ? "Jesteś krasnoludem" : (wzrost < 170) ? "Jesteś średniego wzrostu" : "Jesteś wysoki";
            Console.WriteLine($"Twój wzrost to {wzrost} cm. {kategoria}");
        }
        else
        {
            Console.WriteLine("Niepoprawny format danych. Wzrost powinien być liczbą całkowitą.");
        }
    }
}