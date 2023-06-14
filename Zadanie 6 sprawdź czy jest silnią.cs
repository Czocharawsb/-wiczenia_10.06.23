// See https://aka.ms/new-console-template for more information
Console.WriteLine("podaj liczbę x");
int x=int.Parse(Console.ReadLine());
int sil = 1;
int a = 0;
int n = 0;
int check = 0;
while (sil <= x)
{
    a++;
    sil = sil * a;
    n++;
    if (sil == x)
    {
        Console.WriteLine("liczba jest slinią liczby n=" + n);
        check = 1;
    }
    
}
if (check != 1)
{
    Console.WriteLine("Nie jest silnią");
}






