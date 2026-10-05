using System;

namespace BelajarCSharp
{
    class Praktik_Modul_3_Dictionary
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 ---\n");
            /*
        Buat:
            Dictionary<string, string>
        dengan data:
            nama → Tera
            kota → Jakarta
            pekerjaan → Programmer
        Kemudian tampilkan value dari key "nama".
            */
            Dictionary<string, string> data = new Dictionary<string, string>();

            data.Add("nama", "Tera");
            data.Add("kota", "Jakarta");
            data.Add("pekerjaan", "Programmer");

            Console.WriteLine($"Nama : {data["nama"]}");
            Console.WriteLine($"Kota : {data["kota"]}");
            Console.WriteLine($"Pekerjaan : {data["pekerjaan"]}");

            Console.WriteLine($"Jumlah data : {data.Count}");
            Console.WriteLine();
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 ---\n");
            /*
            Buat:
                Dictionary<string, int>
            dengan:
                Tera → 25
                Budi → 30
                Andi → 22
            Tampilkan:
                Umur Tera: 25
            */
            Dictionary<string, int> data = new Dictionary<string, int>();

            data.Add("Tera", 25);
            data.Add("Budi", 30);
            data.Add("Andi", 22);

            Console.WriteLine($"Umur Tera : {data["Tera"]}");
            Console.WriteLine();
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 ---\n");
            /*
            Gunakan Count untuk menampilkan jumlah data.
            Target: Jumlah siswa: 3
            */
            Dictionary<string, int> data = new Dictionary<string, int>();

            data.Add("Tera", 25);
            data.Add("Budi", 30);
            data.Add("Andi", 22);

            Console.WriteLine($"Jumlah Siswa : {data.Count}");
            Console.WriteLine();
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 ---\n");
            /*
            Gunakan ContainsKey() untuk mengecek apakah key "Andi" tersedia.
            Kalau ada:
                Andi ditemukan.
            Kalau tidak:
                Andi tidak ditemukan.
            */
            Dictionary<string, int> data = new Dictionary<string, int>();

            data.Add("Tera", 25);
            data.Add("Budi", 30);
            data.Add("Andi", 22);

            if (data.ContainsKey("Andi"))
            {
                Console.WriteLine("Andi ditemukan");
            }
            else
            {
                Console.WriteLine("Andi tidak ditemukan");
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 ---\n");
            /*
            Gunakan Remove() untuk menghapus key "Budi".

            Kemudian tampilkan seluruh Dictionary menggunakan:

            foreach (KeyValuePair<string, int> item in siswa)
            */
            Dictionary<string, int> siswa = new Dictionary<string, int>();

            siswa.Add("Tera", 25);
            siswa.Add("Budi", 30);
            siswa.Add("Andi", 22);

            siswa.Remove("Budi");

            foreach (KeyValuePair<string, int> item in siswa)
            {
                Console.WriteLine($"Nama: {item.Key}, Umur: {item.Value}");
            }
        }

        public static void JalankanPraktik6()
        {
            Console.Write("--- Praktik 6 ---\n");
            /*
            Buat Dictionary:
                1 → Tera
                2 → Budi
                3 → Andi
                4 → Sinta
                5 → Rina
            Kemudian tampilkan:
                ID: 1, Nama: Tera
                ID: 2, Nama: Budi
                ...
            Gunakan KeyValuePair.
            */
            Dictionary<int, string> siswa = new Dictionary<int, string>();

            siswa.Add(1, "Tera");
            siswa.Add(2, "Budi");
            siswa.Add(3, "Andi");
            siswa.Add(4, "Sinta");
            siswa.Add(5, "Rina");

            foreach (KeyValuePair<int, string> item in siswa)
            {
                Console.WriteLine($"ID: {item.Key}, Nama: {item.Value}"); // cara baca: Untuk setiap pasangan key-value di siswa, masukkan pasangan tersebut ke dalam variabel item.
            }
        }

        public static void JalankanPraktik7()
        {
            Console.Write("--- Praktik 7 ---\n");
            /*
            Buat data siswa:
                Tera  → 80
                Budi  → 75
                Andi  → 90
                Sinta → 85
                Rina  → 70
            Kemudian:
                Tampilkan semua siswa dan nilainya.
                Tampilkan jumlah siswa.
                Cek apakah "Andi" ada.
                Tampilkan nilai Andi.
                Hapus "Rina".
            Tampilkan kembali seluruh data setelah Rina dihapus.
            */
            Dictionary<string, int> siswa = new Dictionary<string, int>
            {
                // Dictionary initializer
                { "Tera", 80 },
                { "Budi", 75 },
                { "Andi", 90 },
                { "Sinta", 85 },
                { "Rina", 70 },
            };

            // atau syntax modern:
            /*
            {
                ["Tera"] = 80,
                ["Budi"] = 75,
                ["Andi"] = 90,
                ["Sinta"] = 85,
                ["Rina"] = 70
            };
            */

            // 1. Tampilkan semua siswa dan nilainya
            foreach (KeyValuePair<string, int> item in siswa)
            {
                Console.WriteLine($"Nama: {item.Key}, Nilai: {item.Value}");
            }
            Console.WriteLine();

            // 2. Tampilkan jumlah siswa
            Console.WriteLine($"Jumlah siswa: {siswa.Count}");
            Console.WriteLine();

            // 3. Cek apakah Andi ada
            if (siswa.ContainsKey("Andi"))
            {
                Console.WriteLine("Andi ada");
                // 4. Tampilkan nilai Andi
                Console.WriteLine($"Nilai Andi: {siswa["Andi"]}");
            }
            else
            {
                Console.WriteLine("Andi tidak ada");
            }
            Console.WriteLine();

            // 5. Hapus Rina
            siswa.Remove("Rina");

            // 6. Tampilkan kembali data setelah Rina dihapus
            Console.WriteLine("Data setelah Rina dihapus:");
            foreach (KeyValuePair<string, int> item in siswa)
            {
                Console.WriteLine($"Nama: {item.Key}, Nilai: {item.Value}");
            }
            Console.WriteLine();
        }
    }
}
