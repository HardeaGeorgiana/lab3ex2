using System;

namespace lab3ex2
{
    /*  L3 E2 Scrieti o functie care va determina daca un numar este sau nu numar prim.
              Apelati-o si afisati-i rezultatul
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti un numar pentru a afla daca acesta este prim sau nu");
            int number = int.Parse(Console.ReadLine());
            NumarPrim(number);

        }
        static void NumarPrim (int number)
        {
            if (number <= 1) 
            {
                Console.WriteLine("Introduceti un numar mai mare decat 1");
                return;
            }

            for(int i = 2; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Numarul nu este prim");
                    return;
                }
            }
            Console.WriteLine("Numarul este prim");
        }

    }
}
