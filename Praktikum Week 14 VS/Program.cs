using System;
namespace Praktikum_Week_14_VS
{
    class Program
    {
        static void DeretPrima(int angka)
        {
            //DERET PRIMA
            Console.WriteLine("Output : ");
            var hitung = 1;
            for (int i = 1; i <= angka; i++)
            {
                for (int j = 1; j <= angka; j++)
                {
                    while (true)
                    {
                        hitung++;
                        int cekFaktor = 1;
                        int cek2 = 1;
                        while (cekFaktor != 0)
                        {
                            cek2++;
                            cekFaktor = hitung % cek2;
                        }
                        if (hitung == cek2)
                        {
                            break;
                        }
                    }
                    Console.Write("{0,7}", hitung);
                }
                Console.WriteLine();
            }
        }
        static void DeretNonPrima(int angka)
        {
            //DERET NON PRIMA
            Console.WriteLine("Output : ");
            var hitung = 0;
            for (int i = 1; i <= angka; i++)
            {
                for (int j = 1; j <= angka; j++)
                {
                    while (true)
                    {
                        hitung++;
                        int cekFaktor = 1;
                        int cek2 = 1;
                        while (cekFaktor != 0)
                        {
                            cek2++;
                            cekFaktor = hitung % cek2;
                        }
                        if (hitung != cek2)
                        {
                            break;
                        }
                    }
                    Console.Write("{0,7}", hitung);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //CEK PRIMA INPUT
            Console.Write("Input : ");
            int angka = Convert.ToInt32(Console.ReadLine());
            int faktor = 0;
            for (int i = 1; i <= angka; i++)
            {
                if (angka % i == 0)
                {
                    faktor++;
                }
            }
            if (faktor == 2)
            {
                DeretPrima(angka);
            }
            else
            {
                DeretNonPrima(angka);
            }
        }
    }
}