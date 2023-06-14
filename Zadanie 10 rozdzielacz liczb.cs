namespace Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę,która posiada przynajmniej 3 cyfyry");
            while (true)
            {
                int liczba = int.Parse(Console.ReadLine());
                if (liczba>=100)
                {
                    rozdzielacz_liczb(liczba);
                    break;
                }
                Console.WriteLine("Liczba musi być przynajmniej 3 cyforwa, spróbuj ponownie");
            
            }
            
        }


        public static void rozdzielacz_liczb(int liczba)
        {
            string lstring=liczba.ToString();
            string wynik = "";

            for(int i=0; i<=lstring.Length-1;i++)
            {
                wynik += lstring[i] + "\t";
            }
            Console.WriteLine(wynik);
        
        
        }
            


            
    
    
    
    }
}