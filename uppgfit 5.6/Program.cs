using System;

namespace uppgift_5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int produkt = 1;
            Console.WriteLine("Skriv ut talen du vill multiplicera med med ett * tecken mellan");
            string svar = Console.ReadLine();
            string[] taltext = svar.Split('*');
            for (int i  = 0; i < taltext.Length; i++)
            {
                produkt *= int.Parse(taltext[i]);

            }
            Console.WriteLine(produkt);
        }
    }
}