using System;

namespace BelajarCSharp
{
    class PraktikDua
    {
        public static void JalankanVersi1()
        {
            #region Praktik 1 - Variable & Data Type
            // Praktik 1 - Variable & Data Type
            /*
            Buat variable:
                nama
                umur
                tinggiBadan
                gaji
                isActive
            Dengan tipe yang sesuai.
            Ketentuan:
                nama       → string
                umur       → int
                tinggiBadan → double
                gaji       → decimal
                isActive   → bool
            Kemudian tampilkan semuanya.
            */
            {
                string nama = "Tera";
                Console.WriteLine(nama);

                int umur = 25;
                Console.WriteLine(umur);

                double tinggiBadan = 170;
                Console.WriteLine(tinggiBadan);

                decimal gaji = 10000000m;
                Console.WriteLine(gaji);

                bool isActive = true;
                Console.WriteLine(isActive);
            }
            #endregion

            #region Praktik 2 - Input User
            // Praktik 2 - Input User
            /*
            Buat program yang meminta:
                Nama:
                Umur:
                Kota:
            Contoh:
                Masukkan nama: Tera
                Masukkan umur: 25
                Masukkan kota: Jakarta
            */
            {
                Console.Write("Masukkan Nama: ");
                string nama = Console.ReadLine();
                Console.WriteLine(nama);

                Console.Write("Masukkan Umur: ");
                string umur = Console.ReadLine();
                Console.WriteLine(umur);

                Console.Write("Masukkan Kota: ");
                string kota = Console.ReadLine();
                Console.WriteLine(kota);
            }
            #endregion
        }

        /*
        OPSI LAIN dapat menggunakan Versi yang lebih sederhana, tanpa menggunakan region, tanpa menggunakan {}
        */

        public static void JalankanVersi2()
        {
            // Praktik 1 - Variable & Data Type

            string nama = "Tera";
            int umur = 25;
            double tinggiBadan = 170;
            decimal gaji = 10000000m;
            bool isActive = true;

            Console.WriteLine(nama);
            Console.WriteLine(umur);
            Console.WriteLine(tinggiBadan);
            Console.WriteLine(gaji);
            Console.WriteLine(isActive);

            // Praktik 2 - Input User

            Console.Write("Masukkan Nama: ");
            string namaInput = Console.ReadLine();

            Console.Write("Masukkan Umur: ");
            string umurInput = Console.ReadLine();

            Console.Write("Masukkan Kota: ");
            string kota = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Nama: " + namaInput);
            Console.WriteLine("Umur: " + umurInput);
            Console.WriteLine("Kota: " + kota);
        }

        public static void JalankanVersi3()
        {
            #region Praktik - Nullable Integer
            //Practice 8A — Nullable Integer
            /*
            Buat program:
                Masukkan umur:
            Gunakan:
                int?
            Jika user memasukkan angka:
                Umur kamu: 25
            Jika input kosong/tidak valid:
                Umur tidak tersedia.
            */
            Console.Write("Masukkan umur : ");

            string input = Console.ReadLine();

            // Variable umur boleh memiliki nilai integer atau null int? umurNullable = null;
            int? umurNullable = null;

            // Coba mengubah input string menjadi int
            bool berhasil = int.TryParse(input, out int umur);

            if (berhasil)
            {
                // Jika berhasil, masukkan hasil parsing ke nullable int
                umurNullable = umur;
            }
            // cek apakah umurNullable memiliki nilai
            if (umurNullable.HasValue)
            {
                Console.WriteLine($"Umur kamu: {umurNullable}");
            }
            else
            {
                Console.WriteLine("umur tidak tersedia");
            }
            #endregion
        }

        public static void JalankanVersi4()
        {
            #region Praktik - Nullable Birth Date
            /*
            Buat program:
                Masukkan tanggal lahir:
            Gunakan:
                DateTime?
            Jika valid:
                Tanggal lahir: 14/05/2001
            Jika kosong/tidak valid:
                Tanggal lahir belum tersedia.
            */
            Console.Write("Masukkan tanggal lahir (YYYY-MM-DD) :  ");

            string input = Console.ReadLine();

            DateTime? tanggalLahirNullable = null; // Artinya: tanggalLahirNullable adalah DateTime yang boleh kosong.

            bool berhasil = DateTime.TryParse(input, out DateTime tanggalLahir);

            if (berhasil)
            {
                tanggalLahirNullable = tanggalLahir; // Artinya: Kalau parsing berhasil, masukkan tanggal ke variable nullable.
            }
            if (tanggalLahirNullable.HasValue) // "Apakah tanggalLahirNullable mempunyai nilai?"
            {
                Console.WriteLine($"Tanggal Lahir :  {tanggalLahirNullable.Value:dd/MM/yyyy}"); // dibaca: "Ambil nilai DateTime yang ada di dalam nullable."
            }
            else
            {
                Console.WriteLine("Tanggal lahir belum tersedia.");
            }
            #endregion
        }

        public static void JalankanVersi5()
        {
            #region Praktik - Null Coalescing
            /*
            Buat:
                string? nama = null;
            Kemudian gunakan:
                ??
            sehingga output:
                Nama: Tidak diketahui
            Kemudian ubah:
                string? nama = "Tera";
            */
            string? nama = null;
            // string? nama = "Samara";

            // string hasil = nama ?? "Tera";
            string hasil = nama ?? "Tidak diketahui";

            Console.Write(hasil);
            #endregion
        }

        class Person
        {
            public string? Name { get; set; }
        }

        public static void JalankanVersi6()
        {
            #region Praktik - Null Propagation
            /*
            Buat class:
                class Person
                {
                    public string? Name { get; set; }
                }
            Kemudian:
                Person? orang = null;
            Gunakan:
                ?.
            */
            Person? orang = null;

            Console.WriteLine(orang?.Name);     // Artinya: "Kalau orang ada, ambil Name. Kalau orang null, jangan lanjut."
            #endregion
        }
    }
}
