using System;

namespace BelajarCSharp
{
    // Bagian 4 - Dynamic & Static

    class Counter
    {
        public static int Jumlah = 0;

        public Counter()
        {
            Jumlah++;
            // Console.WriteLine($"Jumlah: {Jumlah}");
            // Console.WriteLine();
        }
    }

    /*
    Soal 1 — Class Paling Dasar
     Buat class:
        Hewan
    Field:
        Nama
        Jenis
    Method:
        TampilkanInfo()
    Buat 2 object:
        Kucing
        Mamalia
        Burung
        Unggas
    Tampilkan datanya.
    */
    class Hewan
    {
        public string Nama;
        public string Jenis;

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Jenis: {Jenis}");
            Console.WriteLine();
        }
    }

    // Soal 2 - Constructor Dasar
    /*
    Buat class:
        Buku
    Field:
        Judul
        Penulis
    Constructor:
        Buku(string judul, string penulis)
    Method:
    TampilkanInfo()
    Buat:
        Laskar Pelangi
        Andrea Hirata
    */
    class Buku
    {
        public string Judul;
        public string Penulis;

        public Buku(string judul, string penulis)
        {
            this.Judul = judul;
            this.Penulis = penulis;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Judul: {Judul}");
            Console.WriteLine($"Penulis: {Penulis}");
            Console.WriteLine();
        }
    }

    // Soal 3 - Constructor Overloading
    /*
    Buat class:
        Motor
    Field:
        Merk
        Tahun
    Buat constructor:
        Motor()
    dan
        Motor(string merk, int tahun)
    Lalu buat object menggunakan kedua constructor tersebut.
    */
    class Motor
    {
        public string Merk;
        public int Tahun;

        public Motor()
        {
            Merk = "Belum di Isi";
            Tahun = 0;
        }

        public Motor(string merk, int tahun)
        {
            Merk = merk;
            Tahun = tahun;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Merk: {Merk}");
            Console.WriteLine($"Tahun: {Tahun}");
            Console.WriteLine();
        }
    }

    // Soal 4 - Property
    /*
    Buat class:
        Mahasiswa
    Property:
        Nama { get; set; }
        Jurusan { get; set; }
    Method:
        TampilkanInfo()
    */

    class Mahasiswaa
    {
        public string Nama { get; set; }
        public string Jurusan { get; set; }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Jurusan: {Jurusan}");
            Console.WriteLine();
        }
    }

    // Soal 5 - Read Only
    /*
    Buat class:
        Laptop
    Field:
        public readonly string SerialNumber;
    Constructor:
        Laptop(string serialNumber)
    Method:
        TampilkanInfo()
    Lalu coba ubah:
    laptop.SerialNumber = "ABC123";

    Perhatikan errornya.
    */
    class Laptoop
    {
        public readonly string SerialNumber;

        public Laptoop(string serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Serial Number: {SerialNumber}");
            Console.WriteLine();
        }
    }

    // Soal 6 - Const
    /*
    Buat class:
        Matematika
    Const:
        PI = 3.14
    Method:
        TampilkanPI()
    Cetak nilainya.
    */
    class Matematika
    {
        const double PI = 3.14;

        public void TampilkanPI()
        {
            Console.WriteLine($"Cetak Nilai: {PI}");
            Console.WriteLine();
        }
    }

    // Soal 7 - Statid Field
    /*
    Buat class:
        Pengunjung
    Static Field:
        JumlahPengunjung
    Constructor:
    Setiap object dibuat:
        JumlahPengunjung++;
        Buat 5 object.
    Cetak:
        Pengunjung.JumlahPengunjung
    */
    // NOTE : Constructor tidak boleh ada static nya
    class Pengunjung
    {
        public static int JumlahPengunjung;

        public Pengunjung()
        {
            JumlahPengunjung++;

        }
    }

    // Soal 8 - Static Method
    /*
    Buat class:
        Kalkulator
    Method:
        public static int Tambah(int a, int b)
        Return hasil penjumlahan.
    Panggil:
        Kalkulator.Tambah(5, 3)
    */
    class Kalkulator
    {
        public static int Tambah(int a, int b)
        {
            return a + b;
        }
    }

    // Soal 9 - Tebak Output
    // hasilnya 2, karena object dibuat 2 kali

    // Soal 10 - Mini Challenge
    /*
    Buat class:
        Pegawai
    Field:
        Nama
        Gaji
    Constructor:
        Pegawai(string nama, int gaji)
    Method:
        TampilkanInfo()
    Static Field:
        JumlahPegawai
    Setiap object dibuat:
        JumlahPegawai++;
        Buat 3 pegawai.
    */
    class Pegawai
    {
        public string Nama;
        public int Gaji;
        public static int JumlahPegawai;

        public Pegawai(string nama, int gaji)
        {
            JumlahPegawai++;
            this.Nama = nama;
            this.Gaji = gaji;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Gaji: {Gaji}");
            Console.WriteLine();
        }
    }
}
