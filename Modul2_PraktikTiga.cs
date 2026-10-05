using System;
using System.Globalization;

namespace BelajarCSharp
{
    class Praktik_Modul_2_Break_Continue
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 - Break ---\n");
            /*
            Buat for dari angka 1 sampai 10.
            Tetapi program harus berhenti ketika mencapai angka 6.
            Target output: 1 - 10
            */
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

                if (i == 6)
                {
                    break;
                }
            }
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 - Break mencari angka ---\n");

            /*
            Gunakan array:
            int[] angka = { 10, 20, 30, 40, 50, 60 };
            Gunakan foreach.
            Cari angka 40.
            Ketika 40 ditemukan:
                Angka ditemukan!
            dan loop harus berhenti.
            */
            int[] angka = { 10, 20, 30, 40, 50, 60 };

            foreach (int nomor in angka)
            {
                Console.WriteLine($"memeriksa : {nomor}");

                if (nomor == 40)
                {
                    Console.WriteLine("Angka ditemukan!");
                    break;
                }
            }
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 - Continue ---\n");
            /*
            Buat for dari 1 sampai 10.
            Cetak hanya angka yang bukan 5.
            */
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 - Continue angka genap---\n");
            /*
            Buat:
                for (int i = 1; i <= 10; i++)
            Gunakan continue untuk melewati angka genap.
            Target: 1, 3, 5, 7, 9
            */
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 - gabungan continue & break---\n");
            /*
            Buat loop:
                1 sampai 10
            Ketentuannya:
                angka genap → dilewati menggunakan continue
                ketika angka mencapai 7 → berhenti menggunakan break
                angka lainnya → dicetak
            Target: 1, 3, 5
            */
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                if (i == 7)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }
}
