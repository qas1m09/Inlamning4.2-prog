using System;

namespace Inlämning4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal:");
            int heltal = int.Parse(Console.ReadLine());

            Console.WriteLine("Vill du skriva in ett till heltal (ja/nej)?");
            string svar = Console.ReadLine();

            while ( svar == "ja")
            {
                Console.WriteLine("Skriv in ett heltal");
                int tal = int.Parse(Console.ReadLine());

                if (tal > heltal)
                {
                    heltal = tal;
                }

                Console.WriteLine("Vill du skriva in ett till heltal (ja/nej)?"); 
                svar = Console.ReadLine();

            }

            Console.WriteLine("Det största talet var " + heltal);

        }
    }    
    
}