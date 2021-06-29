using System;

namespace Esercizio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dato un array di 5 interi, verificare che gli elementi siano in ordine crescente.

            do
            {

                int[] magnus = new int[5];

                Console.WriteLine("Inserisci il primo valore");
                magnus[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Inserisci il secondo valore");
                magnus[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Inserisci il terzo valore");
                magnus[2] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Inserisci il quarto valore");
                magnus[3] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Inserisci il quinto valore");
                magnus[4] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();



                bool flag = false;

                Console.WriteLine("Hai inserito i seguenti valori:\n");
                for (int i = 0; i <= magnus.Length - 1; i++)
                {
                    Console.WriteLine(magnus[i]);
                        }

                Console.WriteLine();
                for (int i = 0; i < magnus.Length - 1; i++)
                {
                    if (magnus[i] > magnus[i + 1])
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }

                if (flag) //se vero
                {
                    Console.WriteLine("Sono in ordine crescente");
                }
                else
                {
                    Console.WriteLine("Non sono in ordine crescente");
                }
                Console.WriteLine();
                Console.WriteLine("Vuoi continuare? Premi 'y' se vuoi continuare. Altrimenti un qualsiasi altro tasto per uscire.");
                Console.WriteLine();

            } while (Console.ReadKey().KeyChar == 'y');
            Console.WriteLine();
        }
    }
}
