// See https://aka.ms/new-console-template for more information
int n =int.Parse(Console.ReadLine());
int min = 1;
int max = n - 1;
while(true)
{
        if (min == max)
        {
        Console.WriteLine(min + "\t " + max + "\t");
        Console.WriteLine("0\t" + n + "\t");
        Console.WriteLine(n+"\t0"+ "\t");
        break;
        }
    if (min > max) 
    {
        Console.WriteLine("0\t" + n + "\t");
        Console.WriteLine(n + "\t0" + "\t");
        break;
    }
    
    Console.Write(min + "\t " + max + "\t");
    
    min++;
    max--;

   





}