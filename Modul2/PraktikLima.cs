using System;

namespace BelajarCSharp
{
    class Praktik_Modul_2_Checked_Unchecked
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 - int.MaxValue ---\n");
            /*
            Buat program yang menampilkan:
                Nilai maksimum int: 2147483647
            Gunakan:
                int.MaxValue
            */
            int angka = int.MaxValue;

            // Console.Write("Masukkan angka : ");
            // angka = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nilai maksimum int : {angka}");
            Console.WriteLine();
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 - int.MaxValue ---\n");
            /*
            buat program:
                Nilai maksimum: 2147483647
                Terjadi overflow.
            Gunakan:
                int.MaxValue
                checked
                try
                catch
                OverflowException
            */
            try
            {
                int max = int.MaxValue;
                int hasil = checked(max + 1);

                Console.WriteLine(hasil);
                Console.WriteLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi Overflow!");
                Console.WriteLine();
            }
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Unchecked 3 - int.MaxValue ---\n");
            /*
            Buat program yang melakukan:
                2147483647 + 1
            menggunakan:
                unchecked
            Kemudian tampilkan hasilnya.
            Target:
                Hasil: -2147483648
            */
            int max = int.MaxValue;
            int hasil = unchecked(max + 1);

            Console.WriteLine(hasil);
            Console.WriteLine();
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Unchecked 4 - Bandingkan ---\n");
            /*
            Buat satu method yang menunjukkan perbedaan:
                CHECKED
                Overflow terdeteksi.
                UNCHECKED
            Hasil: -2147483648
            Gunakan try-catch untuk bagian checked.
            */
            Console.WriteLine("CHECKED");
            Console.WriteLine();

            try
            {
                int max = int.MaxValue;

                int hasil = checked(max + 1);

                Console.WriteLine(hasil);
                Console.WriteLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow terdeteksi.");
            }
            Console.WriteLine();

            Console.WriteLine("UNCHECKED");

            int maxUnchecked = int.MaxValue;

            int hasilUnchecked = unchecked(maxUnchecked + 1);

            Console.WriteLine($"Hasil : {hasilUnchecked}");
            Console.WriteLine();
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Unchecked 5 - Tantangan ---\n");
            /*
            Buat program:
                Masukkan angka: 2147483647
                Masukkan tambahan: 1
            Kemudian lakukan penjumlahan menggunakan:
            checked
            Jika terjadi overflow:
                Hasil terlalu besar untuk tipe data int.
            Kalau tidak overflow:
                Hasil: ...
            Untuk latihan ini boleh menggunakan int.Parse() dulu, supaya kita fokus ke checked/unchecked.
            */
            try
            {
                Console.Write("Masukan angka : ");
                int angka = int.Parse(Console.ReadLine());

                Console.Write("Masukkan tamabahan : ");
                int tambahan = int.Parse(Console.ReadLine());

                int hasil = checked(angka + tambahan);

                Console.WriteLine();
                Console.WriteLine($"Hasil : {hasil}");
            }
            catch (OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Hasil terlalu besar untuk tipe data int.");
            }
        }
    }
}
