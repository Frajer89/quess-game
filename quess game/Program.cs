using System;

namespace quess_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int nahodnecislo;
            bool neuhodl = true;
            int hadanecislo;
            nahodnecislo = random.Next(1, 100);



            Console.WriteLine("Hádací hra");
            Console.WriteLine("----------------------");
            Console.WriteLine("Myslím si číslo od 1 do 100");



            while (neuhodl)
            {
                Console.WriteLine("tipni hodnotu:");
                hadanecislo = int.Parse(Console.ReadLine());
                if (hadanecislo > nahodnecislo) 
                {
                    Console.WriteLine("to je moc");
                } 
                else if (hadanecislo < nahodnecislo) 
                {
                    Console.WriteLine("to je málo");
                }
                else 
                {
                    Console.WriteLine("Výborně, uhádnul jsi");
                    neuhodl = false;
                }
                
            }

            Console.ReadLine();






        }
    }
}
