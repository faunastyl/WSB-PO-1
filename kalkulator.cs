/*Zadanie 1: Prosty kalkulator dwóch liczb
Opis: Napisz program, który prosi użytkownika o dwie liczby oraz o wybór operacji arytmetycznej (+, -, * lub /). Następnie, w zależności od wybranego działania, program oblicza wynik i wyświetla go na ekranie. Użyj instrukcji warunkowej (if/elif) do rozpoznania operacji.
Przykład:
Wejście: 10, 20, +
Wyjście: Wynik: 30*/

using System;

class Program
{
    static void Main() {
        Console.Write("Podaj pierwszą liczbę: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz działanie (+, -, *, /): ");
        string dz = Console.ReadLine();

        if (dz == "+") {
            Console.WriteLine("Wynik: " + (num1 + num2));
        }
        else if (dz == "-") {
            Console.WriteLine("Wynik: " + (num1 - num2));
        }
        else if (dz == "*") {
            Console.WriteLine("Wynik: " + (num1 * num2));
        }
        else if (dz == "/") {
            if (num2 == 0) {
                Console.WriteLine("Nie można dzielić przez 0.");
            }
            else {
                Console.WriteLine("Wynik: " + (num1 / num2));
            }
        }
        else {
            Console.WriteLine("Niepoprawne działanie.");
        }
    }
}
