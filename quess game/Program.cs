using System;

namespace quess_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nahodnecislo;

            nahodnecislo = random.Next (1, 100);
            Console.WriteLine(nahodnecislo);
            

            Console.WriteLine("Hádací hra");
            Console.WriteLine("----------------------");
            Console.WriteLine("Myslím si číslo od 1 do 100");

            Console.ReadLine();
            
            

            
        }
    }
}
