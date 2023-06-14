// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Podaj n i k (nie mogą być mniejsze od 5):");
decimal m;
bool check = true;
while (check)
{
    int n = int.Parse(Console.ReadLine());
    int k = int.Parse(Console.ReadLine());
    if (k >= 5 && n >= 5)
    {
        check = false;
        m = (funkcja(n) - funkcja(k)) / funkcja(k);
        Console.WriteLine("Wynik: " + m);
    }
    else
    {
        Console.WriteLine("Niepoprawna liczba, spróbuj ponownie");
    }
}

int funkcja(int a)
{
    int wynik = 1;
    for (int i = 1; i <= a; i++)
    {
        wynik *= i;
    }
    return wynik;
}