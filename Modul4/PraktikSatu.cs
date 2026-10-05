using System;

namespace BelajarCSharp
{
    class Praktik_Modul_4_Function
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 ---\n");
            /*
        Buat function:
            JalankanPraktik1()
        Di dalamnya buat function lain bernama:
            Sapa()
        yang menampilkan:
            Halo, selamat belajar C#!
        Kemudian panggil Sapa().
            */
            static void Sapa()
            {
                Console.WriteLine("Halo, selamat belajar C#!");
                Console.WriteLine();
            }
            Sapa();
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 ---\n");
            /*
        Buat function:
            SapaNama(string nama)
        Kemudian panggil:
            SapaNama("Tera");
            SapaNama("Budi");
            SapaNama("Andi");
        Output:
            Halo Tera
            Halo Budi
            Halo Andi
            */
            static void SapaNama(string nama)
            {
                Console.WriteLine($"Halo {nama}");
            }
            SapaNama("Tera");
            SapaNama("Budi");
            SapaNama("Andi");
            Console.WriteLine();
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 ---\n");
            /*
            Buat function:
            Penjumlahan(int angka1, int angka2)
            Function harus mengembalikan hasil penjumlahan.
            Kemudian:
            10 + 20
            dan tampilkan:
            Hasil: 30
            */
            // static void Penjumlahan(int angka1, int angka2)
            // {
            //     int hasil = angka1 + angka2;
            //     Console.WriteLine($"Hasil: {hasil}");
            //     Console.WriteLine();
            // }
            // Penjumlahan(10, 20);
            // atau
            /*
            static void Penjumlahan(int angka1, int angka2)
            {
                Console.WriteLine($"Hasil: {angka1 + angka2}");
                Console.WriteLine();
            }
            Penjumlahan(10, 20);
            */
            // atau

            static int Penjumlahan(int angka1, int angka2)
            {
                return angka1 + angka2;
            }
            int hasil = Penjumlahan(10, 20);
            Console.WriteLine(hasil);
            Console.WriteLine();
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 ---\n");
            /*
            Buat:
                Perkalian(int angka1, int angka2, int angka3)
            Function tersebut harus menggunakan function Penjumlahan() terlebih dahulu.
            Misalnya:
                5 + 4 = 9
                9 × 6 = 54
            Hasil: 54
            */
            static int Penjumlahan(int a, int b)
            {
                return a + b;
            }

            static int Perkalian(int a, int b, int c)
            {
                int hasilJumlah = Penjumlahan(a, b);

                return hasilJumlah * c;
            }

            int hasil = Perkalian(4, 5, 6);
            Console.WriteLine($"Hasil : {hasil}");
            Console.WriteLine();
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 ---\n");
            /*
            Buat function:
                TampilkanNama(params string[] nama)
            Kemudian panggil:
            TampilkanNama("Tera", "Budi", "Andi", "Sinta", "Rina");
            dan tampilkan semua nama menggunakan foreach.
            */
            static void TampilkanNama(params string[] nama)
            {
                foreach (string item in nama)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
            TampilkanNama("Tera", "Budi", "Andi", "Sinta", "Rani");
        }
    }
}
