using System;
using System.Collections.Generic;

namespace BelajarCSharp
{
    class Praktik_Modul_3_SortedList
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 Membuat SortedList ---\n");
            /*
        Buat:
            SortedList<int, string>
        dengan data:
        3 → Andi
        1 → Tera
        5 → Rina
        2 → Budi
        4 → Sinta
        Tampilkan menggunakan foreach.
        Perhatikan apakah hasilnya mengikuti urutan input atau urutan key.
            */
            SortedList<int, string> siswa = new SortedList<int, string>();

            siswa.Add(3, "Andi");
            siswa.Add(1, "Tera");
            siswa.Add(5, "Rina");
            siswa.Add(2, "Budi");
            siswa.Add(4, "Sinta");

            foreach (KeyValuePair<int, string> item in siswa)
            {
                Console.WriteLine($"ID: {item.Key}, Nama: {item.Value}");
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 Mengambil berdasarkan Key ---\n");
            /*
        Tampilkan nama dengan key 3.
        Target:
        Nama dengan ID 3: Andi
            */
            SortedList<int, string> siswa = new SortedList<int, string>();

            siswa.Add(3, "Andi");
            siswa.Add(1, "Tera");
            siswa.Add(5, "Rina");
            siswa.Add(2, "Budi");
            siswa.Add(4, "Sinta");

            Console.WriteLine($"Nama dengan ID 3: {siswa[3]}");
            Console.WriteLine();
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 Count ---\n");

            // Tampilkan jumlah siswa.
            SortedList<int, string> siswa = new SortedList<int, string>();

            siswa.Add(3, "Andi");
            siswa.Add(1, "Tera");
            siswa.Add(5, "Rina");
            siswa.Add(2, "Budi");
            siswa.Add(4, "Sinta");

            Console.WriteLine($"jumlah siswa: {siswa.Count}");
            Console.WriteLine();
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 ContainsKey ---\n");
            /*
            Cek apakah key 4 ada.
            Jika ada:
            ID 4 ditemukan.
            */
            SortedList<int, string> siswa = new SortedList<int, string>();

            siswa.Add(3, "Andi");
            siswa.Add(1, "Tera");
            siswa.Add(5, "Rina");
            siswa.Add(2, "Budi");
            siswa.Add(4, "Sinta");

            if (siswa.ContainsKey(4))
            {
                Console.WriteLine("ID 4 ditemukan");
            }
            else
            {
                Console.WriteLine("ID 4 tidak ditemukan");
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 Remove ---\n");
            /*
            Hapus key 2.
            Kemudian tampilkan seluruh data setelah dihapus.
            */
            SortedList<int, string> siswa = new SortedList<int, string>();

            siswa.Add(3, "Andi");
            siswa.Add(1, "Tera");
            siswa.Add(5, "Rina");
            siswa.Add(2, "Budi");
            siswa.Add(4, "Sinta");

            siswa.Remove(2);

            Console.WriteLine(siswa);
        }

        public static void JalankanPraktik6()
        {
            Console.Write("--- Praktik 6 Key berdasarkan Index ---\n");
            /*
            gunakan SortedList siswa,
            Tampilkan key pada:
            index 0
            index 1
            index 2
            */
            SortedList<int, string> siswa = new SortedList<int, string>();

            siswa.Add(3, "Andi");
            siswa.Add(1, "Tera");
            siswa.Add(5, "Rina");
            siswa.Add(2, "Budi");
            siswa.Add(4, "Sinta");

            Console.WriteLine(siswa.Keys[0]);
            Console.WriteLine(siswa.Keys[1]);
            Console.WriteLine(siswa.Keys[2]);
            Console.WriteLine();
        }

        public static void JalankanPraktik7()
        {
            Console.Write("--- Praktik 7 Value berdasarkan index ---\n");
            /*
            Dengan data yang sama, tampilkan:
            Value index 0: Tera
            Value index 1: Budi
            Value index 2: Andi
            */

            SortedList<int, string> siswa = new SortedList<int, string>();

            siswa.Add(3, "Andi");
            siswa.Add(1, "Tera");
            siswa.Add(5, "Rina");
            siswa.Add(2, "Budi");
            siswa.Add(4, "Sinta");

            Console.WriteLine($"Value index 0: {siswa.Values[0]}");
            Console.WriteLine($"Value index 1: {siswa.Values[1]}");
            Console.WriteLine($"Value index 2: {siswa.Values[2]}");
        }

        public static void JalankanPraktik8()
        {
            Console.Write("--- Praktik 8 Gabungan ---\n");
            /*
            Tampilkan semua data menggunakan foreach.
            Tampilkan value dari key 4.
            Tampilkan jumlah data.
            Cek apakah key 3 ada.
            Hapus key 5.
            Tampilkan data setelah penghapusan.
            Tampilkan key pada index 0.
            Tampilkan value pada index 0.
            */
            SortedList<int, string> siswa = new SortedList<int, string>();

            siswa.Add(3, "Andi");
            siswa.Add(1, "Tera");
            siswa.Add(5, "Rina");
            siswa.Add(2, "Budi");
            siswa.Add(4, "Sinta");

            Console.WriteLine("1. Tampilkan semua data menggunakan foreach");

            foreach (KeyValuePair<int, string> item in siswa)
            {
                Console.WriteLine($"ID: {item.Key}, Nama: {item.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("2. Tampilkan value dari key 4");
            Console.WriteLine(siswa[4]);
            Console.WriteLine();

            Console.WriteLine("3. Tampilkan jumlah Data");
            Console.WriteLine(siswa.Count);
            Console.WriteLine();

            Console.WriteLine("4. Cek apakah Key 3 ada");
            if (siswa.ContainsKey(3))
            {
                Console.Write("Siswa Key 3 Ada");
            }
            Console.WriteLine();

            Console.WriteLine("5. Hapus Key 5");
            siswa.Remove(5);

            Console.WriteLine("6. Tampilkan data setelah penghapusan");
            foreach (KeyValuePair<int, string> item in siswa)
            {
                Console.WriteLine($"ID: {item.Key}, Nama: {item.Value}");
            }
            Console.WriteLine();

            Console.WriteLine("7. Tampilkan key pada index 0.");
            Console.WriteLine(siswa.Keys[0]);
            Console.WriteLine();

            Console.WriteLine("8. Tampilkan value pada index 0.");
            Console.WriteLine(siswa.Values[0]);
            Console.WriteLine();
        }
    }
}
