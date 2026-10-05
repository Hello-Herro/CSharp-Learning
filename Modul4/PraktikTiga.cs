using System;

namespace BelajarCSharp
{
    class Praktik_Modul_4_GlobalLocal
    {
        public static void JalankanPraktik1()
        {
            Console.WriteLine("--- Praktik 1 Local Variable ---\n");

            string nama = "Tera";
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine();
        }

        static string nama = "Tera";

        public static void JalankanPraktik2()
        {
            Console.WriteLine("--- Praktik 2 Field/Global Variable ---\n");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine();
        }

        static int angka = 10;

        public static void JalankanPraktik3()
        {
            Console.WriteLine("--- Praktik 3 satu field gunakan 2 method ---\n");

            static void MethodA()
            {
                Console.WriteLine($"Angka dari method A: {angka}");
            }
            static void MethodB()
            {
                Console.WriteLine($"Angka dari method B: {angka}");
            }

            MethodA();
            MethodB();

            Console.WriteLine();
        }

        static int saldo = 100000;

        public static void JalankanPraktik4()
        {
            Console.WriteLine("--- Praktik 4 mengubah nilai field ---\n");

            static void TambahSaldo(int jumlah)
            {
                saldo += jumlah;
            }

            Console.WriteLine($"Saldo awal atau sebelum: {saldo}");
            Console.WriteLine();
            TambahSaldo(50000);
            Console.WriteLine($"Saldo setelah ditambah: {saldo}");
            Console.WriteLine();
        }

        static int angkaGlobal = 100;

        public static void JalankanPraktik5()
        {
            Console.WriteLine("--- Praktik 5 bandingkan Local dan Field ---\n");

            int angkaLocal = 50;

            Console.WriteLine($"Angka Global: {angkaGlobal}");
            Console.WriteLine($"Angka Local: {angkaLocal}");
        }
    }
}
