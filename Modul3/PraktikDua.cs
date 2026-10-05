using System;

namespace BelajarCSharp
{
    class Praktik_Modul_3_List
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 - Membuat List ---\n");
            /*
            Buat:
                List<string> nama
            Isi dengan:
                Tera
                Budi
                Andi
                Sinta
                Rina
            Kemudian tampilkan semua menggunakan foreach.
            */
            List<string> nama = new List<string>();

            nama.Add("Tera");
            nama.Add("Budi");
            nama.Add("Andi");
            nama.Add("Sinta");
            nama.Add("Rina");

            foreach (string siswa in nama)
            {
                Console.WriteLine(siswa);
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 - Add() & Count() ---\n");
            /*
            Buat:
                List<int> angka = new List<int>();
            Tambahkan angka:
                10
                20
                30
                40
                50
            menggunakan Add().
            Kemudian tampilkan:
                Jumlah data: 5
            Gunakan Count.
            */
            List<int> angka = new List<int>();

            angka.Add(10);
            angka.Add(20);
            angka.Add(30);
            angka.Add(40);
            angka.Add(50);

            Console.WriteLine($"Jumlah Data : {angka.Count}");
            Console.WriteLine();
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 - Index ---\n");
            /*
            Gunakan List:
                10
                20
                30
                40
                50
            Tampilkan:
            Nilai index 0: 10
            Nilai index 1: 20
            ...
            Gunakan for.
            */
            List<int> angka = new List<int>();

            angka.Add(10);
            angka.Add(20);
            angka.Add(30);
            angka.Add(40);
            angka.Add(50);

            for (int i = 0; i < angka.Count; i++)
            {
                Console.WriteLine($"Nilai index ke-{i}: {angka[i]}");
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 - AddRange() ---\n");
            /*
            Buat dua List:
            List pertama:
                Tera
                Budi
                Andi

            List kedua:
                Sinta
                Rina
            Gabungkan List kedua ke List pertama menggunakan:
                AddRange()
            Kemudian tampilkan semua nama.
            */
            List<string> namaPertama = new List<string>();

            namaPertama.Add("Tera");
            namaPertama.Add("Budi");
            namaPertama.Add("Andi");

            List<string> namaKedua = new List<string>();

            namaKedua.Add("Sinta");
            namaKedua.Add("Rina");

            namaPertama.AddRange(namaKedua); // cara baca: "Tambahkan semua isi namaKedua ke namaPertama."

            foreach (string nama in namaPertama) // cara menampilkan list namanya
            {
                Console.WriteLine(nama);
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 - Insert() ---\n");

            List<string> nama = new List<string>();

            nama.Add("Tera");
            nama.Add("Budi");
            nama.Add("Sinta");
            nama.Add("Rina");

            nama.Insert(2, "Andi");

            foreach (string siswa in nama)
            {
                Console.WriteLine(siswa);
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik6()
        {
            Console.Write("--- Praktik 6 - RemoveAt() ---\n");

            List<string> nama = new List<string>();

            nama.Add("Tera");
            nama.Add("Budi");
            nama.Add("Andi");
            nama.Add("Sinta");
            nama.Add("Rina");

            nama.RemoveAt(2);

            foreach (string siswa in nama)
            {
                Console.WriteLine(siswa);
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik7()
        {
            Console.Write("--- Praktik 7 - Total angka ---\n");
            /*
            Hitung total menggunakan foreach.
            Target:
                Total: 150
            */
            List<int> angka = new List<int> { 10, 20, 30, 40, 50 };

            int total = 0;

            foreach (int nomor in angka)
            {
                total += nomor;
            }
            Console.WriteLine($"Total: {total}");
            Console.WriteLine();
        }

        public static void JalankanPraktik8()
        {
            Console.Write("--- Praktik 8 - Tantangan ---\n");
            /*
            Buat:
            List<int> angka = new List<int>
                {
                    10, 75, 30, 90, 45, 60
                };
            Tampilkan hanya angka yang:
            > 50
            Target:
                75
                90
                60
            */
            List<int> angka = new List<int> { 10, 75, 30, 90, 45, 60 };

            for (int i = 0; i < angka.Count; i++)
            {
                if (angka[i] > 50)
                {
                    Console.WriteLine(angka[i]);
                }
            }
        }

        public static void JalankanPraktik9()
        {
            Console.Write("--- Praktik 9 - Cari nilai terbesar ---\n");

            List<int> angka = new List<int> { 10, 75, 30, 90, 45, 60 };

            int terbesar = angka[0];

            foreach (int nilai in angka)
            {
                if (nilai > terbesar)
                {
                    terbesar = nilai;
                }
                /*Cara membacanya:
                Saya anggap angka pertama adalah yang terbesar.
                Kemudian saya periksa angka satu per satu.
                Kalau menemukan angka yang lebih besar, saya ganti terbesar.
                */
            }
            Console.WriteLine($"Nilai terbesar: {terbesar}");

            Console.WriteLine();
        }

        public static void JalankanPraktik10()
        {
            Console.Write("--- Praktik 10 - Hitung jumlah angka genap ---\n");
            List<int> angka = new List<int> { 10, 75, 30, 90, 45, 60 };

            int jumlahGenap = 0;

            foreach (int nilai in angka)
            {
                if (nilai % 2 == 0)
                {
                    jumlahGenap++; // menghitung berapa data.
                }
            }
            Console.WriteLine($"Jumlah Angka Genap : {jumlahGenap}");

            Console.WriteLine();
        }

        public static void JalankanPraktik11()
        {
            Console.Write("--- Praktik 11 - Cari nama ---\n");
            /*
            Cari apakah "Andi" ada di dalam List.
            Jika ditemukan:
                Andi ditemukan.
            Jika tidak:
                Andi tidak ditemukan.
            Gunakan boolean flag seperti yang sebelumnya kita pelajari:
                bool ditemukan = false;
            Kemudian ketika menemukan "Andi":
                ditemukan = true;
            */
            List<string> nama = new List<string> { "Tera", "Budi", "Andi", "Sinta", "Rina" };

            bool ditemukan = false;

            foreach (string siswa in nama)
            {
                if (siswa == "Andi")
                {
                    ditemukan = true;
                    break;
                }
            }   
            if (ditemukan)
            {
                Console.WriteLine("Andi ditemukan.");
            }
            else
            {
                Console.WriteLine("Andi Tidak ditemukan.");
            }

            Console.WriteLine();
        }

        public static void JalankanPraktik12()
        {
            Console.Write("--- Praktik 12 - Hapus data berdasarkan Index ---\n");
            /*
            Hapus "Andi" menggunakan RemoveAt().
            Tetapi kali ini jangan langsung:
                nama.RemoveAt(2);
            Cari dulu index "Andi" menggunakan for.
            */
            List<string> nama = new List<string> { "Tera", "Budi", "Andi", "Sinta", "Rina" };

            int indexAndi = -1; // Karena index List dimulai dari 0.

            for (int i = 0; i < nama.Count; i++) // karena indeks adalah angka jadi harus integer bukan string i
            {
                if (nama[i] == "Andi")
                {
                    indexAndi = i;
                    break;
                }
            }

            if (indexAndi != -1)
            {
                Console.WriteLine("Nama Andi ditemukan.");
                nama.RemoveAt(indexAndi);
            }
            else
            {
                Console.WriteLine("Nama Andi tidak ditemukan.");
            }

            foreach (string siswa in nama)
            {
                Console.WriteLine(siswa);
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik13()
        {
            Console.Write("--- Praktik 13 - Insert() + RemoveAt() ---\n");
            /*
            Lakukan dua operasi:
                Insert "Andi" pada index 2
                Remove "Budi" berdasarkan index-nya
            Target akhir:
                Tera
                Andi
                Sinta
                Rina
            Perhatikan bahwa setelah Insert(), index data berubah.
            */
            List<string> nama = new List<string> { "Tera", "Budi", "Sinta", "Rina" };

            nama.Insert(2, "Andi");

            int indexBudi = -1;

            for (int i = 0; i < nama.Count; i++)
            {
                if (nama[i] == "Budi")
                {
                    indexBudi = i;
                    break;
                }
            }

            if (indexBudi != -1)
            {
                nama.RemoveAt(indexBudi);
            }

            foreach (string siswa in nama)
            {
                Console.WriteLine(siswa);
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik14()
        {
            Console.Write("--- Praktik 14 - Gabungan AddRange() + Filter ---\n");
            /*
            Buat dua List:
                Gabungkan angkaKedua ke angkaPertama menggunakan AddRange().
            Kemudian tampilkan hanya angka lebih besar dari 30.
            */
            List<int> angkaPertama = new List<int> { 10, 20, 30 };

            List<int> angkaKedua = new List<int> { 40, 55, 70 };

            angkaPertama.AddRange(angkaKedua);

            foreach (int angka in angkaPertama)
            {
                if (angka > 30)
                {
                    Console.WriteLine($"Tampilkan angka yang lebih besar dari 30 : {angka}");
                }
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik15()
        {
            Console.Write("--- Praktik 15 - Tantangan ---\n");
            /*
            Buat:
            List<int> angka = new List<int>
            {
                10, 25, 30, 45, 50, 65
            };

            Hitung:
                Total seluruh angka
                Jumlah angka genap
                Jumlah angka ganjil
                Angka terbesar
            Target:
                Total: 225
                Jumlah genap: 4
                Jumlah ganjil: 2
                Nilai terbesar: 65
            */
            List<int> angka = new List<int> { 10, 25, 30, 45, 50, 65 };

            int total = 0;
            int jumlahGenap = 0;
            int jumlahGanjil = 0;
            int terbesar = angka[0];

            foreach (int nilai in angka)
            {
                //Hitung total
                total += nilai;

                //Hitung genap dan ganjil
                if (nilai % 2 == 0)
                {
                    jumlahGenap++;
                }
                else
                {
                    jumlahGanjil++;
                }

                // cari nilai terbesar
                if (nilai > terbesar)
                {
                    terbesar = nilai;
                }
                Console.WriteLine($"Total: {total}");
                Console.WriteLine($"Jumlah genap: {jumlahGenap}");
                Console.WriteLine($"Jumlah ganjil: {jumlahGanjil}");
                Console.WriteLine($"Nilai terbesar: {terbesar}");

                Console.WriteLine();
            }
        }

        /*
        Latihan ArrayList

        Sekarang kita praktik seperti pola belajar kita sebelumnya.

        Buat class:

        using System.Collections;

        namespace BelajarCSharp;

        class Praktik_Modul_3_ArrayList
        {
            public static void JalankanPraktik1()
            {
                // latihan di sini
            }
        }
        Praktik 1 — Membuat ArrayList

        Buat ArrayList bernama nama.

        Masukkan:

        Tera
        Budi
        Andi
        Sinta
        Rina

        Kemudian tampilkan semua menggunakan foreach.

        Praktik 2 — Count

        Buat ArrayList:

        10
        20
        30
        40
        50

        Tampilkan jumlah datanya.

        Target:

        Jumlah data: 5
        Praktik 3 — Index

        Buat:

        Tera
        Budi
        Andi
        Sinta

        Tampilkan:

        Data index 0: Tera
        Data index 1: Budi
        Data index 2: Andi
        Data index 3: Sinta

        Petunjuk: kali ini gunakan for, karena kita membutuhkan index.

        Praktik 4 — Data campuran

        Buat sebuah ArrayList yang berisi:

        "Tera"
        25
        170.5
        true

        Tampilkan semuanya menggunakan foreach.

        Petunjuk:

        foreach (object item in data)
        Praktik 5 — Insert

        Buat:

        Tera
        Budi
        Andi
        Rina

        Kemudian masukkan "Sinta" ke index 2.

        Hasil:

        Tera
        Budi
        Sinta
        Andi
        Rina
        Praktik 6 — Remove

        Buat:

        Tera
        Budi
        Andi
        Sinta
        Rina

        Hapus "Andi" menggunakan:

        Remove()
        Praktik 7 — RemoveAt

        Gunakan data yang sama:

        Tera
        Budi
        Andi
        Sinta
        Rina

        Hapus data pada index 2 menggunakan:

        RemoveAt()
        Praktik 8 — Gabungan

        Buat ArrayList:

        10
        25
        30
        45
        50
        65

        Lakukan:

        Tampilkan semua angka.
        Tampilkan jumlah data.
        Tampilkan angka yang lebih besar dari 30.
        Hapus angka 45.
        Tampilkan isi ArrayList setelah dihapus.
        */
    }
}
