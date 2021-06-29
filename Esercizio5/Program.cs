using System;

namespace Esercizio5
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dato un array di 5 interi, ordinare gli elementi in ordine crescente.
            //Stampare l'array ordinato


            do
            {
                

                int[] valore = new int[5];
                int varTemp = 0;
                int check = 0;
                int a = valore.Length;
                int b = valore.Length;

                Console.WriteLine("Inserisci il primo valore");
                valore[0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Inserisci il secondo valore");
                valore[1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Inserisci il terzo valore");
                valore[2] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Inserisci il quarto valore");
                valore[3] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Inserisci il quinto valore");
                valore[4] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

            
                Console.WriteLine("Hai inserito i seguenti valori:\n");
                for (int i = 0; i <= valore.Length - 1; i++)
                {
                    Console.WriteLine(valore[i]);
                }

                Console.WriteLine();
                do
                {
                    check = 0;
                    for (int i = 0; i < (a - 1); i++)
                        if (valore[i] > valore[i + 1])
                        {
                            varTemp = valore[i];
                            valore[i] = valore[i + 1];
                            valore[i + 1] = varTemp;
                            check = 1;
                            b = i + 1;
                        }
                    a = b;
                }
                while (check == 1);
                Console.WriteLine();


                Console.WriteLine("Questi sono i valori ordinati in modo crescente:\n");
                for (int i = 0; i <= valore.Length - 1; i++)
                {
                    Console.WriteLine(valore [i]);
                }
                Console.WriteLine();
                Console.WriteLine("Vuoi continuare? Premi 'y' se vuoi continuare. Altrimenti un qualsiasi altro tasto per uscire.");
                Console.WriteLine();

            } while (Console.ReadKey().KeyChar == 'y');
            Console.WriteLine();
        }
    }
}
