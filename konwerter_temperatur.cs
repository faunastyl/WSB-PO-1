/*Konwerter temperatur (Celsjusz ↔ Fahrenheit)
Opis: Napisz program, który umożliwia konwersję temperatur między skalą Celsjusza a Fahrenheita.
Uownik najpierw wybiera kierunek konwersji: C – jeśli chce przeliczyć stopnie Celsjusza na Fahrenheity,
lub F – jeśli chce przeliczyć stopnie Fahrenheita na Celsjusze.
Następnie podaje wartość temperatury w wybranej skali, a program przelicza ją i wyświetla wynik.
Wykorzystaj instrukcję warunkową do rozróżnienia dwóch przypadków konwersji.
(Wzory konwersji: °F = °C * 1.8 + 32, °C = (°F – 32) / 1.8)*/



using System;

class Program
{
    static void Main()
    {
        Console.Write("Wybierz konwersję: C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz: ");
        string wybor = Console.ReadLine();

        Console.Write("Podaj temperaturę: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (wybor == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine(temp + "°C = " + wynik + "°F");
        }
        else if (wybor == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine(temp + "°F = " + wynik + "°C");
        }
        else
        {
            Console.WriteLine("Niepoprawny wybór.");
        }
    }
}
