using System;
using System.Globalization;

namespace BelajarCSharp
{
    class PraktikSatu
    {
        public static void Jalankan()
        {
            // Practice 01 — Variable
            /*
            Buat:
                nama
                umur
                tinggiBadan
                gaji
                isActive
            */
            {
                Console.Write("--- Practice 1 - Variable ---");
                Console.WriteLine(); // Ini akan memberikan jarak 1 baris kosong
                string nama = "Tera";
                int umur = 25;
                double tinggiBadan = 170;
                decimal gaji = 12000000m;
                bool isActive = true;

                Console.WriteLine(nama);
                Console.WriteLine(umur);
                Console.WriteLine(tinggiBadan);
                Console.WriteLine(gaji);
                Console.WriteLine(isActive);
            }

            // Practice 02 - Input
            /*
            Program meminta:
                Nama
                Umur
                Kota
            Kemudian mencetak profil user.
            */
            {
                Console.Write("--- Practice 2 - Input ---\n");
                Console.Write("Masukan Nama: ");

                string namaInput = Console.ReadLine();

                Console.Write("Masukan Umur: ");
                string umurInput = Console.ReadLine();

                Console.Write("Masukan Kota: ");
                string kotaInput = Console.ReadLine();

                Console.WriteLine();

                Console.WriteLine("Nama: " + namaInput);
                Console.WriteLine("Umur: " + umurInput);
                Console.WriteLine("Kota: " + kotaInput);
            }

            // Practice 03 — Calculator atau Operator
            /*
            Input:
                angka pertama
                angka kedua
            Output:
                Penjumlahan
                Pengurangan
                Perkalian
                Pembagian
                Sisa pembagian
            */
            {
                Console.Write("--- Practice 3 - Calculator atau Operator ---\n");

                Console.Write("Angka Pertama: ");
                int angka1 = int.Parse(Console.ReadLine());
                Console.Write("Angka Kedua: ");
                int angka2 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Hasil penjumlahan: " + (angka1 + angka2));
                Console.WriteLine("Hasil pengurangan: " + (angka1 - angka2));
                Console.WriteLine("Hasil perkalian: " + (angka1 * angka2));
                Console.WriteLine("Hasil pembagian: " + ((double)angka1 / angka2));
                Console.WriteLine("Hasil sisa pembagian: " + (angka1 % angka2));
            }

            // Practice 04 - Conversion
            /*
            User memasukkan umur sebagai string:
                "25"
            Ubah menjadi:
                int
            Gunakan:
                int.TryParse()
            */
            {
                Console.Write("--- Practice 4 - Conversion Parse() ---\n");

                Console.Write("masukan umur: ");
                int umur = int.Parse(Console.ReadLine());
                Console.WriteLine(umur);
            }
            // atau
            {
                Console.Write("--- Practice 4 - Conversion TryParse() ---\n");

                Console.Write("masukan umur: ");
                bool berhasil = int.TryParse(Console.ReadLine(), out int umur);
                if (berhasil)
                {
                    Console.WriteLine(umur);
                }
                else
                {
                    Console.WriteLine("Input bukan angka");
                }
            }

            // Practice 05 - String Manipulation
            /*
            User memasukkan nama lengkap.
            Program menampilkan:
                Nama asli
                Nama uppercase
                Nama lowercase
                Panjang nama
                Nama setelah Trim
            dan juga:
                Halo, {nama}
            menggunakan string interpolation.
            */
            {
                Console.Write("--- Practice 5 - String Manipulation ---\n");

                Console.Write("Masukkan Nama lengkap: ");
                string namaInput = Console.ReadLine();

                Console.WriteLine("Nama Asli: " + namaInput);
                Console.WriteLine("Nama Uppercase: " + namaInput.ToUpper());
                Console.WriteLine("Nama Lowercase: " + namaInput.ToLower());
                Console.WriteLine("Panjang Nama: " + namaInput.Length);
                Console.WriteLine("Nama setlah Trim: " + namaInput.Trim());
                Console.WriteLine($"Halo, {namaInput}");
            }

            // Praktice 06 - DateTime Manipulation
            // A. Date Profile
            /*
            Buat program yang memiliki:
                Tanggal lahir
            Kemudian tampilkan:
                Tanggal lahir
                Tahun lahir
                Bulan lahir
                Hari lahir
            */
            {
                Console.Write("--- Practice 6 - DateTime Manipulation ---\n");
                Console.Write("--- A. Date Profile ---\n");

                DateTime tanggalLahir = new DateTime(2001, 5, 14);

                int tahun = tanggalLahir.Year;
                int bulan = tanggalLahir.Month;
                int hari = tanggalLahir.Day;

                Console.WriteLine($"tanggal Lahir : {tanggalLahir:yyyy-MM-dd}");
                Console.WriteLine($"tahun Lahir : {tahun}");
                Console.WriteLine($"bulan Lahir  : {bulan}");
                Console.WriteLine($"hari Lahir : {hari}");
            }

            // B. Future Date
            /*
            membuat Input:
                Masukkan jumlah hari:
            Misalnya:
                30
            Tampilkan:
                Hari ini:
                30 hari lagi:
            Gunakan:
                AddDays()
            */
            {
                Console.Write("--- B. Future Date ---\n");

                Console.Write("Masukkan jumlah hari: ");

                bool berhasil = int.TryParse(Console.ReadLine(), out int jumlahHari);

                if (berhasil)
                {
                    DateTime hariIni = DateTime.Now;
                    DateTime futureDate = hariIni.AddDays(jumlahHari);

                    Console.WriteLine($"Hari ini : {hariIni:yyyy-mm-dd hh:mm:ss}");

                    Console.WriteLine($"{jumlahHari} hari lagi : {futureDate:yyyy-mm-dd hh:mm:ss}");
                }
            }

            //C. Age Calculator
            /*
            User memasukkan:
                Tanggal lahir
            Kemudian program menghitung perkiraan umur berdasarkan tahun sekarang.
            Contoh:
                Tanggal lahir: 2000-05-20
                
                Umur: 26 tahun
            Tidak perlu membuat perhitungan umur yang sangat kompleks dulu. Fokus pada DateTime dan pengurangan tahun.
            */
            {
                Console.Write("--- C. Age Calculator ---\n");

                Console.Write("Masukkan Tanggal Lahir format (YYYY-MM-DD)   :   ");

                string input = Console.ReadLine();

                bool berhasil = DateTime.TryParse(input, out DateTime tanggalLahir);

                if (berhasil)
                {
                    // menginisiasikan variabel tahun dari variabel tanggal lahir agar diubah menjadi tahun
                    int tahunLahir = tanggalLahir.Year;

                    // membuat variabel baru bernama tahunSekarang dimana berisi tahun sekarang
                    DateTime tahunSekarang = DateTime.Now;
                    int tahunIni = tahunSekarang.Year;

                    // menghitung selisih tahun lahir dengan tahun sekarang kemudian menampilkan hasilnya
                    int selish = tahunIni - tahunLahir;
                    Console.WriteLine($"tanggal lahirmu : {tanggalLahir}");
                    Console.WriteLine($"berarti sekarang umurmu : {selish} tahun");
                }
                else
                {
                    Console.WriteLine("Format tanggal tidak valid.");
                }
            }

            //Practice 07 - Decimal & Formatting
            //A. Product Price
            /*
            Buat:
                Nama produk
                Harga
                Jumlah
            Kemudian hitung:
                Subtotal
            Format harga sebagai:
                Rp...
            */
            {
                Console.Write("--- Practice 7 - Decimal & Formatting ---\n");
                Console.Write("--- A. Product Price ---\n");

                string produkA = "Dancow Coklat";
                decimal harga = 18000m;
                int jumlah = 2;

                decimal subtotal = harga * jumlah;

                Console.WriteLine($"Produk  : {produkA}");
                Console.WriteLine(
                    $"Harga : {harga.ToString(
                        "C2",                                           //C2  berhubungan dengan formatting dan juga berarti currency dengan 2 angka desimal contoh Rp.18.000,00
                        CultureInfo.CreateSpecificCulture("id-ID")      // ini adalah class dari .NET yang berisi informasi tentang budaya/format suatu wilayah
                    )}"
                );

                Console.WriteLine($"Jumlah  : {jumlah}");
                Console.WriteLine(
                    $"subtotal  : {subtotal.ToString(
                        "C2",
                        CultureInfo.CreateSpecificCulture("id-ID")
                    )}"
                );
            }

            //B. Discount
            /*
            User mengInput:
                Harga:
                Diskon:
            Contoh:
                Harga: 250000
                Diskon: 10%
            Output:
                Harga awal:
                Diskon:
                Nilai diskon:
                Harga setelah diskon:
            Gunakan decimal.
            */

            // NOTE: untuk perhitungan jangan menggunakan diskon.ToString("P2") karena itu mengubah angka menjadi teks
            {
                Console.Write("--- B. Discount ---\n");

                Console.Write("Masukkan Harga: ");
                decimal harga = decimal.Parse(Console.ReadLine());

                Console.Write("Masukkan Diskon (%): ");
                decimal diskon = decimal.Parse(Console.ReadLine());

                // mengubah 10 menjadi 0.10
                decimal nilaiDiskon = diskon / 100m; 

                // minghitung nominal potongan
                decimal potongan = harga * nilaiDiskon;

                // menghitung harga setelah diskon
                decimal total = harga - potongan;

                Console.WriteLine($"Harga awal  :   {harga}" );
                Console.WriteLine($"Diskon  :   {diskon} %");
                Console.WriteLine($"Nilai diskon    :   {nilaiDiskon}");
                Console.WriteLine($"Harga setelah diskon    :    {total}");
            }
        }
    }
}
