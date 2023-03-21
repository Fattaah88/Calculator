using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkulator_4814
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nAplikasi Kalkulator Sederhana \n");
            Console.WriteLine("1. Penjumlahan \n2. Pengurangan \n3. Perkalian \n4. Pembagian");
            Console.WriteLine("_________");
            Console.Write("Pilih 1/2/3/4 : ");
            char pilih = char.Parse(Console.ReadLine());
            Console.WriteLine("_________");

            // Input Angka
            Console.Write("Input nilai a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input nilai b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_________");


            switch (pilih)
            {
                case '1':
                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " + " + b + " = " + penjumlahan(a, b));
                    break;
                case '2':
                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " - " + b + " = " + pengurangan(a, b));
                    break;
                case '3':
                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " * " + b + " = " + perkalian(a, b));
                    break;
                case '4':
                    Console.WriteLine("Hasil");
                    Console.WriteLine(a + " / " + b + " = " + pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, hasil tidak ditemukan");
                    break;
            }

            Console.WriteLine("\n");


            static int penjumlahan(int a, int b)
            {
                return a + b;
            }
            static int pengurangan(int a, int b)
            {
                return a - b;
            }
            static int perkalian(int a, int b)
            {
                return a * b;
            }
            static int pembagian(int a, int b)
            {
                return a / b;
            }
        }
    }
}
