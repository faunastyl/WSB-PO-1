/******************************************************************************

ZADANIE:
Poproś ucznia o podanie ocen z wybranych przedmiotów na pierwsze i drugie półrocze.
Oblicz średnią ocen półrocznych i na zakonczenie roku. Podaj je uczniowi. /
Ask the student to submit their grades in the selected subjects for the first and second semesters.
Calculate the average of the half-year and end-of-year marks. Give these to the student.

*******************************************************************************/
using System;

class Program
{
    static void Main()
    {
        string[] tab = { "matematyka", "fizyka", "chemia", "biologia", "język angielski" };

        double[] sem1 = new double[5];
        double[] sem2 = new double[5];

        // Pierwszy semestr
        Console.WriteLine("Podaj oceny za pierwszy semestr:");

        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(tab[i] + ": ");
            sem1[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Drugi semestr
        Console.WriteLine("Podaj oceny za drugi semestr:");

        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write(tab[i] + ": ");
            sem2[i] = Convert.ToDouble(Console.ReadLine());
        }

        double suma1 = 0;
        double suma2 = 0;

        // Sumowanie ocen
        for (int i = 0; i < tab.Length; i++)
        {
            suma1 += sem1[i];
            suma2 += sem2[i];
        }

        double srednia_sem1 = suma1 / tab.Length;
        double srednia_sem2 = suma2 / tab.Length;
        double srednia_roczna = (srednia_sem1 + srednia_sem2) / 2;

        Console.WriteLine("Średnia semestru pierwszego: " + Math.Round(srednia_sem1, 2));
        Console.WriteLine("Średnia semestru drugiego: " + Math.Round(srednia_sem2, 2));
        Console.WriteLine("Średnia roczna: " + Math.Round(srednia_roczna, 2));
    }
}


