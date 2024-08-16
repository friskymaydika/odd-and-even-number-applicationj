using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_and_even_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Applications: Odd And Even Number Generator ===".PadLeft(40));
            Console.WriteLine("\n--------------------------------------------\n"); // Mencetak garis putus-putus untuk pemisahan.
            Console.WriteLine("Name: Mochammad Frisky Maydika Soleh"); // Mencetak nama.
            Console.WriteLine("NO: 18"); // Mencetak nomor.
            Console.WriteLine("Class: X PPLG\n"); // Mencetak kelas.

            Console.WriteLine("Bilangan genap:");
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0) // Jika sisa bagi 2 sama dengan 0, maka genap
                {
                    Console.WriteLine(i + " ");
                }
            }

            Console.WriteLine("\nBilangan ganjil:");
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 != 0) // Jika sisa bagi 2 tidak sama dengan 0, maka ganjil
                {
                    Console.WriteLine(i + " ");
                }

            }
        }
    }
}
