namespace Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            
            
                int liczba=int.Parse(Console.ReadLine());
                int odwroconaLiczba = OdwrocLiczbe(liczba);
                Console.WriteLine(odwroconaLiczba);



            






       
        }
        public static int OdwrocLiczbe(int liczba)
        {
            string liczbaStr = liczba.ToString();
            string wynikStr = "";

            for (int i = liczbaStr.Length-1; i >= 0; i--)
            {
                wynikStr += liczbaStr[i];
            }

            return int.Parse(wynikStr);
        }


    }

}