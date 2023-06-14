using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wprowadź kwotę początkową:");
        decimal kwotaP = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Wprowadź oprocentowanie w skali roku:");
        decimal oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Wprowadź liczbę miesięcy oszczędzania:");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal kwotaZarobiona = ObliczKwoteZar(kwotaP, oprocentowanie, liczbaMiesiecy);

        Console.WriteLine("Kwota zarobiona (uwzględniając podatek Belki): {0}", kwotaZarobiona);
    }

    static decimal ObliczKwoteZar(decimal kwotaP, decimal opr, int liczbaMiesiecy)
    {
        decimal oprocentowanieMiesieczne = opr / 12 / 100;
        decimal kwotaZarobiona = kwotaP * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy);

        decimal podatekBelki = 0.19m * (kwotaZarobiona - kwotaP);

        kwotaZarobiona -= podatekBelki;

        return kwotaZarobiona;
    }
}