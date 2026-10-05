using System;
using System.Collections.Generic;

namespace BelajarCSharp
{
    class Praktik_Modul_3_Queue
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 Membuat Queue ---\n");

            Queue<string> antrean = new Queue<string>();

            antrean.Enqueue("Tera");
            antrean.Enqueue("Budi");
            antrean.Enqueue("Andi");
            antrean.Enqueue("Sinta");
            antrean.Enqueue("Rina");

            foreach (string nama in antrean)
            {
                Console.WriteLine(nama);
            }
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 Dequeue ---\n");
            /*
            keluarkan 2 orang pertama menggunakan:
                Dequeue()
            Tampilkan siapa yang keluar.
            Hasilnya harus:
                Yang keluar: Tera
                Yang keluar: Budi
            Kemudian tampilkan isi Queue yang tersisa:
                Andi
                Sinta
                Rina
            */
            Queue<string> antrean = new Queue<string>();

            antrean.Enqueue("Tera");
            antrean.Enqueue("Budi");
            antrean.Enqueue("Andi");
            antrean.Enqueue("Sinta");
            antrean.Enqueue("Rina");

            string orangPertama = antrean.Dequeue();
            string orangKedua = antrean.Dequeue();

            Console.WriteLine($"Yang keluar: {orangPertama}");
            Console.WriteLine($"Yang keluar: {orangKedua}");
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 Peek ---\n");
            /*
            Buat Queue:
                Tera
                Budi
                Andi
            Gunakan:
                Peek()
            untuk mengetahui siapa yang berada di depan.
            Kemudian tampilkan Count.
            Perhatikan bahwa setelah Peek():
                Count tetap 3
            */
            Queue<string> antrean = new Queue<string>();

            antrean.Enqueue("Tera");
            antrean.Enqueue("Budi");
            antrean.Enqueue("Andi");

            Console.WriteLine(antrean.Peek());
            Console.WriteLine($"Jumlah data: {antrean.Count}");
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 Contains ---\n");
            /*
            Cek:
            Apakah Andi ada?
            Apakah Dodi ada?
            Gunakan:
            Contains()
            */
            Queue<string> antrean = new Queue<string>();

            antrean.Enqueue("Tera");
            antrean.Enqueue("Budi");
            antrean.Enqueue("Andi");
            antrean.Enqueue("Sinta");
            antrean.Enqueue("Rina");

            if (antrean.Contains("Andi"))
            {
                Console.WriteLine("Andi ada");
            }
            else
            {
                Console.WriteLine("Andi tidak ada");
            }

            if (antrean.Contains("Dodi"))
            {
                Console.WriteLine("Dodi ada");
            }
            else
            {
                Console.WriteLine("Dodi tidak ada");
            }
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 Simulasi Antrean ---\n");
            /*
            1. Tampilkan antrean
            2. Layani orang pertama
            3. Tampilkan siapa yang dilayani
            4. Tampilkan antrean setelah pelayanan
            5. Lihat siapa yang sekarang berada di depan
            6. Tampilkan jumlah orang yang tersisa
            */
            Queue<string> antrean = new Queue<string>();

            antrean.Enqueue("Tera");
            antrean.Enqueue("Budi");
            antrean.Enqueue("Andi");
            antrean.Enqueue("Sinta");
            antrean.Enqueue("Rina");

            Console.WriteLine("1. Tampilkan antrean");
            foreach (string nama in antrean)
            {
                Console.WriteLine(nama);
            }

            Console.WriteLine();

            Console.WriteLine("2. Layani orang pertama");
            string yangDilayani = antrean.Dequeue();

            Console.WriteLine($"Yang dilayani: {yangDilayani}");

            Console.WriteLine();

            Console.WriteLine("3. Tampilkan siapa yang dilayani");
            Console.WriteLine($"Yang dilayani: {yangDilayani}");

            Console.WriteLine();
            
            Console.WriteLine("4. Tampilkan antrean setelah pelayanan");

            foreach (string nama in antrean)
            {
                Console.WriteLine(nama);
            }

            Console.WriteLine();

            Console.WriteLine("5. Lihat siapa yang berada di depan");
            Console.WriteLine($"Orang berikutnya: {antrean.Peek()}");

            Console.WriteLine();

            Console.WriteLine("6. Tampilkan jumlah orang yang tersisa");
            Console.WriteLine($"Jumlah orang tersisa: {antrean.Count}");
            Console.WriteLine();
        }
    }
}
