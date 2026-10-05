using System;

namespace BelajarCSharp
{
    class Laptop
    {
        public string Merk; // ini disebut Field, Field adalah variabel yang dimiliki class
        public string RAM; // Field

        public void Tampilkaninfo() // Method, Method adalah fungsi yang dimiliki class.
        {
            Console.WriteLine($"Merk : {Merk}");
            Console.WriteLine($"RAM  : {RAM}");
            Console.WriteLine();
        }
    }

    // Note : Keyword 'this' tidak bisa digunakan di static method.

    class Kamera
    {
        public string Nama; // Field
        public int Harga; // Field

        public void CetakInfo()
        {
            Console.WriteLine($"Nama : {Nama}");
            Console.WriteLine($"Harga : {Harga}");
            Console.WriteLine();
        }
    }

    class Fotografer
    {
        public string nama; // Field
        public string spesialisasi; // Field

        public Fotografer(string nama, string spesialisasi) // --> Constructor
        {
            this.nama = nama;
            this.spesialisasi = spesialisasi;
        }

        public void Perkenalan()
        {
            Console.WriteLine($"Halo saya {nama}");
            Console.WriteLine($"Spesialisasi saya {spesialisasi}");
            Console.WriteLine();
        }
    }

    class RekeningBank
    {
        public string NamaPemilik;
        public int Saldo;

        public void Setor(int jumlah)
        {
            Saldo += jumlah;
        }

        public void Tarik(int jumlah)
        {
            Saldo -= jumlah;
        }

        public void LihatSaldo()
        {
            Console.WriteLine($"Saldo : {Saldo}");
        }
    }
}
