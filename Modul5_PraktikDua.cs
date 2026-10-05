using System;

namespace BelajarCSharp
{
    class Mahasiswa
    {
        // public string Nama;
        public int NIM;
        public string Jurusan;
        private int umur;
        private string nama;

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"NIM: {NIM}");
            Console.WriteLine($"Jurusan: {Jurusan}");
            Console.WriteLine($"Umur: {Umur}");
            Console.WriteLine();
        }

        public int Umur
        {
            get { return umur; }
            set
            {
                if (value > 0)
                {
                    umur = value;
                }
            }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }
    }

    class Laptopp
    {
        public string Merk;
        public string RAM;
        public int Harga;

        public void TampilkanInfo()
        {
            Console.WriteLine($"Merk: {Merk}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Harga: {Harga}");
            // Console.WriteLine($"Umur: {Umur}");
            Console.WriteLine();
        }
    }

    class Produk
    {
        public string NamaProduk;
        private int harga;

        public int Harga
        {
            get { return harga; }
            set
            {
                if (harga > 0)
                {
                    harga = value;
                }
            }
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama Produk: {NamaProduk}");
            Console.WriteLine($"Harga Produk: {harga}");
            Console.WriteLine();
        }
    }

    class Karyawan
    {
        public string Nama;
        public string Jabatan;
        public int Gaji;

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama Karyawan: {Nama}");
            Console.WriteLine($"Jabatan Karyawan: {Jabatan}");
            Console.WriteLine($"Gaji Karyawan: {Gaji}");
            Console.WriteLine();
        }
    }

    class Mobil
    {
        public string Merk; // Field
        public int Tahun; // Field

        public Mobil(string Merk, int Tahun) // Constructor 2 Parameter
        {
            this.Merk = Merk;
            this.Tahun = Tahun;
        }

        public void TampilkanInfo() // Method
        {
            Console.WriteLine($"Merk: {Merk}");
            Console.WriteLine($"Tahun: {Tahun}");
            Console.WriteLine();
        }
    }
}
