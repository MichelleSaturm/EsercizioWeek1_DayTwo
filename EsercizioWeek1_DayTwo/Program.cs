using System;

namespace EsercizioWeek1_DayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESERCIZIO 1 - CALCOLATRICE

            //Scrivere un programma che consente all'utente di inserire due numeri,
            //scegliere che operazione compiere tra i due numeri e stampare il risultato. 
            //A questo punto, l'utente deve poter ricominciare dall'inserimento dei numeri, 
            //finchè non sceglie di uscire.

            char scelta;

            do
            {
                Console.WriteLine("Inserisci il primo numero");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Inserisci il secondo numero");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Cosa vuoi fare?");
                Console.WriteLine("1 - Somma; \n2 - Sottrazione; \n3 - Moltiplicazione; \n4 - Divisione;\n0 - Esci;");

                scelta = Console.ReadKey().KeyChar;

                int risultato;

                switch (scelta)
                {
                    case '1':
                        risultato = firstNumber + secondNumber;
                        Console.WriteLine($"Il risultato di {firstNumber} + {secondNumber} è {risultato}");
                        break;
                    case '2':
                        risultato = firstNumber - secondNumber;
                        Console.WriteLine($"Il risultato di {firstNumber} - {secondNumber} è {risultato}");
                        break;
                    case '3':
                        risultato = firstNumber * secondNumber;
                        Console.WriteLine($"Il risultato di {firstNumber} * {secondNumber} è {risultato}");
                        break;
                    case '4':
                        risultato = firstNumber / secondNumber;
                        Console.WriteLine($"Il risultato di {firstNumber} / {secondNumber} è {risultato}");
                        break;
                    case '0':
                        break;
                    default:
                        risultato = 0;
                        Console.WriteLine("La scelta non è corretta.");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Vuoi continuare? Premi 'y' se vuoi continuare. Altrimenti un qualsiasi altro tasto per uscire.");


            } while (Console.ReadKey().KeyChar == 'y');
            Console.WriteLine();
           
        }
    }
    }
