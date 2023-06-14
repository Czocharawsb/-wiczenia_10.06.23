// See https://aka.ms/new-console-template for more information
Console.WriteLine("odpowiedz"+" liczbą ujemną, jeśli propozycja jest mniejsza od szukanej liczby,\r\n. liczbą dodatnią, jeśli propozycja jest większa od szukanej liczby,\r\n. zerem jeśli algorytm odgadł liczbę.");
Random generator = new Random();
int liczba = generator.Next(1,21);
int inp = 0;
int wyn = liczba;
int counter = 0;
int gran = 0;
Console.WriteLine(liczba);
while (true)
{

    

    inp=int.Parse(Console.ReadLine());
    if(inp==0)
    {
        Console.WriteLine("udało się");
        break;
        
    }
    if(inp>0)
    {       if (counter > 0)
        {
            if (gran == 0)
            {
                Console.WriteLine("Błąd wyjście po za zakres");
                break;
            }
            Console.WriteLine(gran);
            gran--;


        }
        else
        {
            
            wyn = generator.Next(1, liczba - 1);
            Console.WriteLine(wyn);
            counter++;
             gran = wyn;
            gran++;
        }
       
    }
    if(inp<0)
    {       if(counter > 0)
            {
                if (wyn == 21)
                {
                Console.WriteLine("Błąd wyjście po za zakres");
                break;
                }
            Console.WriteLine(gran);
            gran++;
            }
    else
        {
            
            wyn = generator.Next(liczba + 1, 21);
            Console.WriteLine(wyn);
            counter++;
             gran = wyn;
            gran++;
        }
       
       
    }


}