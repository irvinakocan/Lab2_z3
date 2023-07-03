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


            int maxSumaKolone = 0;
            int kolona = 0;
            int minSumaReda = 0;
            int red = 0;

            for(int i = 0; i < n; i++)
            {
                int sumaKolone = 0;
                int sumaReda = 0;
                for (int j = 0; j < n; j++)
                {
                    sumaKolone += matrica[j, i];
                    sumaReda += matrica[i, j];
                }

                if (sumaKolone > maxSumaKolone)
                {
                    maxSumaKolone = sumaKolone;
                    kolona = i;
                }

                if(sumaReda < minSumaReda || minSumaReda == 0)
                {
                    minSumaReda = sumaReda;
                    red = i;
                }
            }

            Console.WriteLine("\nKolona sa najvećom sumom elemenata je: {0}", kolona + 1);
            Console.WriteLine("Red sa najmanjom sumom elemenata je: {0}", red + 1);

        }
    }
}