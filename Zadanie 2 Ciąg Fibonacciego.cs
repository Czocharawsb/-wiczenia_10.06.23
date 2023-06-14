// See https://aka.ms/new-console-template for more information
Console.WriteLine("Podaj liczbę:");
int n=int.Parse(Console.ReadLine());
int Temp1 = 1;
int wart = 0;
for (int i=0;i<=n;i++)
{
    if (i == 1)
    {
        wart = Temp1;
        
    }
    if(i > 2) 
    {
        wart = wart +Temp1;
        Temp1 = wart-Temp1;
        
    }
    Console.WriteLine("wyraz ciągu :"+i+"wartość ciągu:\t"+wart);

}
