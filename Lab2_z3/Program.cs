using System;

namespace Lab2_z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prirodan broj n: ");
            string unos = Console.ReadLine();
            while(Int32.Parse(unos) <= 0)
            {
                Console.WriteLine("Unijeli ste broj koji nije prirodan. Ponovite unos: ");
                unos = Console.ReadLine();
            }
            int n = Int32.Parse(unos);


            int[,] matrica = new int[n, n];
            Console.WriteLine("\nUnesite elemente kvadratne matrice {0}x{0}:\n", n, n);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Unesite elemente {0}. reda (razdvojene razmakom):", i + 1);
                string ulaz = Console.ReadLine();
                string[] pojedinacniUlazi = ulaz.Split(" ");

                for (int j = 0; j < n; j++)
                    matrica[i, j] = Int32.Parse(pojedinacniUlazi[j]);
            }


            Console.WriteLine("\nUnijeli ste matricu:");
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}  ", matrica[i, j]);
                Console.WriteLine("");
            }

        }
    }
}