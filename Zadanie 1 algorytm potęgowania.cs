// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj podstawę potegowania i wykładnik:");
int podstawa  = int.Parse(Console.ReadLine());
int wyk = int.Parse(Console.ReadLine());
int temp = 0;
temp = podstawa;
if (wyk > 0)
{
    
    for (int i = 1; i < wyk; i++)
    {
        podstawa = podstawa * temp;
        
    }

    Console.WriteLine("wynik to:" + podstawa);

}




if (wyk==0)
{
    podstawa = 1;
    Console.WriteLine("wynik to:" + podstawa);
}
    