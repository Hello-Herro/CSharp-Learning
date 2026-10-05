using System;
using System.Globalization;

namespace BelajarCSharp
{
    class Praktik_Modul_2_Khusus_Foreach
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 - Cetak semua nama ---\n");
            /*
            Buat array:
                Tera
                Budi
                Andi
                Sinta
                Rina
            Kemudian gunakan foreach untuk menghasilkan:
                Tera
                Budi
                Andi
                Sinta
                Rina
            */
            string[] nama = { "Tera", "Budi", "Andi", "Sinta", "Rina" };

            foreach (string user in nama) // cara baca: "Untuk setiap string yang ada di dalam array nama, masukkan satu per satu ke variabel user."
            {
                Console.WriteLine(user);
            }
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 - Cetak semua angka ---\n");
            /*
            Buat:
                int[] angka =
                {
                    10,
                    20,
                    30,
                    40,
                    50
                };
            */
            int[] angka = { 10, 20, 30, 40, 50 };

            foreach (int nomor in angka) // cara baca: "Untuk setiap angka bertipe int yang ada di dalam array angka, masukkan satu angka tersebut ke variabel nomor"
            {
                Console.WriteLine(nomor);
            }
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 - Cetak angka genap ---\n");
            /*
            menggunakan foreach + if
            int[] angka =
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            */
            int[] angka = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int angkaSekarang in angka)
            {
                if (angkaSekarang % 2 == 0)
                {
                    Console.WriteLine($"Ini angka genap : {angkaSekarang}");
                    Console.WriteLine();
                }
                else if (angkaSekarang % 2 != 0)
                {
                    Console.WriteLine($"Ini angka ganjil : {angkaSekarang}");
                    Console.WriteLine();
                }
            }
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 - Cetak angka lebih dari 50 ---\n");
            /*
            Kita punya:
            int[] angka =
            {
                10, 75, 30, 90, 45, 60
            };
            Gunakan foreach untuk mencetak hanya angka yang lebih dari 50.
            Output:
                75
                90
                60
            */
            int[] angka = { 10, 75, 30, 90, 45, 60 };

            foreach (int angkaSekarang in angka)
            {
                if (angkaSekarang > 50)
                {
                    Console.WriteLine(angkaSekarang);
                }
            }
                    Console.WriteLine();
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 - Hitung semua total angka ---\n");
            /*
            Data:
            int[] angka =
            {
                10, 20, 30, 40, 50
            };

            Target:
            Total: 150
            */
            int[] angka = { 10, 20, 30, 40, 50 };

            int total = 0;
            foreach (int angkaSekarang in angka)
            {
                total = total + angkaSekarang; // artinya: "Ambil total yang sekarang, tambahkan dengan angka yang sedang diproses, lalu simpan kembali ke total."
                // total += angkaSekarang;
            }
            Console.WriteLine(total);
            Console.WriteLine();
        }

        public static void JalankanPraktik6()
        {
            Console.Write("--- Praktik 6 - Cari angka terbesar ---\n");
            /*
            Data:
                int[] angka =
                {
                    25, 10, 75, 40, 90, 30
                };
            Target:
                Angka terbesar: 90
            Kita membutuhkan:
                int terbesar = 0;
            Kemudian setiap angka dibandingkan dengan terbesar.
            */
            int[] angka = { 25, 10, 75, 40, 90, 30 };

            int terbesar = 0;

            foreach (int angkaSekarang in angka)
            {
                if (angkaSekarang > terbesar)
                {
                    terbesar = angkaSekarang;
                }
            }
            Console.WriteLine($"Angka terbesar adalah : {terbesar}");
            Console.WriteLine();
        }

        public static void JalankanPraktik7()
        {
            Console.Write("--- Praktik 7 - Hitung jumlah angka Genap ---\n");
            /*
            Sekarang kita gabungkan:
                foreach
                +
                if
                +
                %
                +
                counter
            Data:
                int[] angka =
                {
                    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                };
            Target:
                Jumlah angka genap: 5
            */
            int[] angka = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int jumlahGenap = 0;

            foreach (int angkaSekarang in angka)
            {
                if (angkaSekarang % 2 == 0)
                {
                    jumlahGenap++;
                }
            }
            Console.WriteLine($"Jumlah angka genap: {jumlahGenap}");
            Console.WriteLine();
        }

        public static void JalankanPraktik8()
        {
            Console.Write("--- Praktik 8 - Cari nama tertent ---\n");
            /*
            kita gabungkan foreach dengan if dan bool.
            Data:
                string[] nama =
                {
                    "Tera",
                    "Budi",
                    "Andi",
                    "Sinta",
                    "Rina"
                };
            Program mencari:
                Andi
            Jika ditemukan:
                Nama ditemukan!
            Jika tidak:
                Nama tidak ditemukan.
            */
            string[] nama = { "Tera", "Budi", "Andi", "Sinta", "Rina" };

            bool ditemukan = false; // Artinya: "Saya belum menemukan Andi."

            foreach (string namaAnda in nama)
            {
                if (namaAnda == "Prabowo")
                {
                    ditemukan = true;
                }
            }
            if (ditemukan)
            {
                Console.WriteLine("Nama ditemukan!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Nama tidak ditemukan.");
                Console.WriteLine();
            }
        }
    }
}
