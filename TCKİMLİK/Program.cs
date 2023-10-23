using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCKİMLİK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tc kimlik numaranızı giriniz");
            string girilen = Console.ReadLine();

            bool donustu_mu = long.TryParse(girilen , out long cikan);
            if (donustu_mu) 
            {
                if (cikan.ToString().Length == 11) 
                {
                    long ilk9 = cikan / 100;
                    long son2 = cikan % 100;
                    long tek_toplam = 0, cift_toplam = 0;

                    long b9 = ilk9 % 10;
                    tek_toplam += b9;
                    ilk9 /= 10;

                    long b8 = ilk9 % 10;
                    cift_toplam += b8;
                    ilk9 /= 10;

                    long b7 = ilk9 % 10;
                    tek_toplam += b7;
                    ilk9 /= 10;

                    long b6 = ilk9 % 10;
                    cift_toplam += b6;
                    ilk9 /= 10;

                    long b5 = ilk9 % 10;
                    tek_toplam += b5;
                    ilk9 /= 10;

                    long b4 = ilk9 % 10;
                    cift_toplam += b4;
                    ilk9 /= 10;

                    long b3 = ilk9 % 10;
                    tek_toplam += b3;
                    ilk9 /= 10;

                    long b2 = ilk9 % 10;
                    cift_toplam += b2;
                    ilk9 /= 10;

                    long b1 = ilk9 % 10;
                    tek_toplam += b1;
                    ilk9 /= 10;

                    long b10 = (tek_toplam * 7 - cift_toplam) % 10;
                    long b11 = (tek_toplam + cift_toplam + b10) % 10;

                    if (son2 == b10 * 10 + b11)
                    {
                        Console.WriteLine("Tutarlıdır.");
                    }
                    else
                    {
                        Console.WriteLine("Tutarsızdır.");
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz kimlik numarası 11 hane değildir!");
                }
            }
            else
            {
                Console.WriteLine("Sayısal bir değer girmediniz!");
                Console.WriteLine();

            }
            Console.WriteLine("Tc kimlik numaranızı giriniz");
            string girilen2 = Console.ReadLine();
            bool donustu2_mu = long.TryParse(girilen2, out long cikan2);
            if (donustu2_mu) 
            {
                if (cikan2.ToString().Length == 11) 
                {
                    long ilk99 = cikan2 / 100;
                    long son22 = cikan2 % 100;
                    long tek_toplamm = 0, cift_toplamm = 0;

                    long b99 =  ilk99 % 10;
                    tek_toplamm += b99;
                    ilk99 /= 10;

                    long b88 = ilk99 % 10;
                    cift_toplamm += b88;
                    ilk99 /= 10;

                    long b77 = ilk99 % 10;
                    tek_toplamm += b77;
                    ilk99 /= 10;

                    long b66 = ilk99 % 10;
                    cift_toplamm += b66;
                    ilk99 /= 10;

                    long b55 = ilk99 % 10;
                    tek_toplamm += b55;
                    ilk99 /= 10;

                    long b44 = ilk99 % 10;
                    cift_toplamm += b44;
                    ilk99 /= 10;

                    long b33 = ilk99 % 10;
                    tek_toplamm += b33;
                    ilk99 /= 10;

                    long b22 = ilk99 % 10;
                    cift_toplamm += b22;
                    ilk99 /= 10;

                    long b11 = ilk99 % 10;
                    tek_toplamm += b11;
                    ilk99 /= 10;

                    long b100 = (tek_toplamm * 7 - cift_toplamm) % 10;
                    long b111 = (tek_toplamm + cift_toplamm + b100) % 10;
                    if (son22 == b100 * 10 + b111)
                    {
                        Console.WriteLine("Tutarlıdır.");
                    }
                    else
                    {
                        Console.WriteLine("Tutarsızdır.");
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz kimlik numarası 11 hane değildir!");
                }
            }
            else
            {
                Console.WriteLine("Sayısal bir değer girmediniz!");
            }
        }
    }
}
