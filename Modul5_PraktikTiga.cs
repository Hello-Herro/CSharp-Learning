using System;

namespace BelajarCSharp
{
    // Bagian 3 - Constant & Read Only
    class Mobill
    {
        // Field
        public readonly string NomorRangka;
        public string Merk;

        // Constructor
        public Mobill(string NomorRangka, string Merk)
        {
            this.NomorRangka = NomorRangka;
            this.Merk = Merk;
        }

        public void TampilkanInfo()
        {
            Console.WriteLine($"Nomor Rangka: {NomorRangka}");
            Console.WriteLine($"Merk: {Merk}");
            Console.WriteLine();
        }

        const int JumlahRodaMobil = 4;

        public static void RodaMobil()
        {
            // JumlahRodaMobil = 6;
            Console.WriteLine($"Jumlah Roda Mobil: {JumlahRodaMobil}");
            Console.WriteLine();
        }
    }
}
