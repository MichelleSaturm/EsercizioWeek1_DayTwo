using System;

namespace Esercizio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data una stringa, scrivere un programma che trova il primo carattere non ripetuto.
            //es.mozzarella -> output m
            //es. sottilissimo -> output l

            //DA FINIRE

            Console.WriteLine("Scrivi una parola");
            string parola = Console.ReadLine();
            Console.WriteLine();


            chat parola = '\0';
            bool check = false;
            

            for (int i = 0; i < parola.Length; i++)
            {
                if (parola[i] != parola[i + 1])
                {
                    contatore++;
                }
                else
                {
                    Console.WriteLine(parola[i]);
                    break;
                }
            }
        }
    }
}
