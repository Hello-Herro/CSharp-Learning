using System;
using System.Collections.Generic;

namespace BelajarCSharp
{
    class Praktik_Modul_4_Overloading
    {
        static int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        static int Penjumlahan(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Tampilkan(int angka)
        {
            Console.WriteLine($"Angka : {angka}");
        }

        static void Tampilkan(string teks)
        {
            Console.WriteLine($"Teks : {teks}");
        }

        static int Luas(int sisi)
        {
            return sisi * sisi;
        }

        static int Luas(int panjang, int lebar)
        {
            return panjang * lebar;
        }

        static decimal HitungHarga(decimal harga, int jumlah)
        {
            return harga * jumlah;
        }

        static decimal HitungHarga(decimal harga, int jumlah, decimal diskon)
        {
            return (harga * jumlah) - diskon;
        }

        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 Overload jumlah parameter ---\n");
            /*
            buat dua function:
            static int Penjumlahan(int a, int b)
            dan:
            static int Penjumlahan(int a, int b, int c)
            Kemudian panggil:
                int hasil1 = Penjumlahan(10, 20);
                int hasil2 = Penjumlahan(10, 20, 30);
            Tampilkan:
                Hasil 2 angka: 30
                Hasil 3 angka: 60
            */
            int hasil1 = Penjumlahan(10, 20);
            int hasil2 = Penjumlahan(10, 20, 30);

            Console.WriteLine($"Hasil 2 angka: {hasil1}");
            Console.WriteLine($"Hasil 3 angka: {hasil2}");
            Console.WriteLine();
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 Overload Tipe Data ---\n");
            /*
            Buat dua function dengan nama:
                Tampilkan()
            Versi pertama menerima:
                int angka
            Versi kedua menerima:
                string teks
            Contoh pemanggilan:
                Tampilkan(100);
                Tampilkan("Halo C#");
            Target:
                Angka: 100
                Teks: Halo C#
            */
            Tampilkan(100);
            Tampilkan("Halo C#");
            Console.WriteLine();
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 Overload untuk menghitung Luas ---\n");
            /*
            Buat:
                Luas()
            Versi pertama:
                Luas(int sisi)
            untuk menghitung luas persegi:
            sisi × sisi
            Versi kedua:
                Luas(int panjang, int lebar)
            untuk menghitung luas persegi panjang:
            panjang × lebar
            Kemudian:
                int luasPersegi = Luas(5);
                int luasPersegiPanjang = Luas(10, 5);
            Target:
            Luas persegi: 25
            Luas persegi panjang: 50
            Perhatikan di sini:
            Luas(5)
            memanggil:
            Luas(int sisi)
            sedangkan:
            Luas(10, 5)
            memanggil:
            Luas(int panjang, int lebar)
            */
            int luasPersegi = Luas(5);
            int luasPersegiPanjang = Luas(10, 5);

            Console.WriteLine($"Luas persegi: {luasPersegi}");
            Console.WriteLine($"Luas persegi panjang: {luasPersegiPanjang}");
            Console.WriteLine();
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 Overload dengan Decimal ---\n");
            /*
            Buat function:
                HitungHarga()
            Versi pertama:
                HitungHarga(decimal harga, int jumlah)
            menghasilkan:
                harga × jumlah
            Versi kedua:
                HitungHarga(decimal harga, int jumlah, decimal diskon)
            menghasilkan:
                (harga × jumlah) - diskon
            */
            decimal hasil1 = HitungHarga(18000m, 2);
            decimal hasil2 = HitungHarga(18000m, 2, 5000m);

            Console.WriteLine($"Harga awal: {hasil1}");
            Console.WriteLine($"Harga setelah diskon: {hasil2}");
            Console.WriteLine();
        }
    }
}
