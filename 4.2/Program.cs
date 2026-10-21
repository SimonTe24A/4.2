using System;

namespace uppgift4_2
{
    class program
    {
        static void Main(string[] args)
        {
            int tal;
            int storstal = int.MinValue;
            string svar;
            do
            {
                Console.WriteLine("Skriv in ett heltal: ");
                tal = Convert.ToInt32(Console.ReadLine());

                if (tal > storstal)
                {
                    storstal = tal;
                }

                Console.WriteLine("vill du skriva in ett tall till? (ja/nej)");
                svar = Console.ReadLine();

            } while (svar.ToLower() == "ja");

            Console.WriteLine("De största talet va " + storstal);
        }        
    }
}

