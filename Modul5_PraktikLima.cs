using System;

namespace BelajarCSharp
{
    // Bagian 5 - Inheritance
    class Kendaraan
    {
        public string Merk;
        public int Tahun;

        public void TampilkanInfo()
        {
            Console.WriteLine($"Merk: {Merk}");
            Console.WriteLine($"Tahun: {Tahun}");
            Console.WriteLine();
        }
    }

    class Mobilll : Kendaraan
    {

    }

    class Pegawaii
    {
        public string Nama;
        public int Gaji;

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Gaji: {Gaji}");
            Console.WriteLine();
        }
    }

    class Programmer : Pegawaii
    {

    }
}