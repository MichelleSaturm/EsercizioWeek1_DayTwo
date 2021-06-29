using System;

namespace Esercizio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Trovare quante volte un certo carattere è contenuto in una stringa

            Console.WriteLine("Scrivi una parola/frase");
            string frase = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Scegli una lettera da contare");
            char carattere = Console.ReadKey().KeyChar;

            int contatore = 0;

            for (int i = 0; i < frase.Length - 1; i++)
            {if (carattere == frase[i])
                { 
                    contatore++;
                }
            
            }
            Console.WriteLine();
            Console.WriteLine($"La lettera {carattere} è stata trovata {contatore} volte nella parola/frase {frase}");


           



        }
    }
}
