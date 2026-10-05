using System;

namespace BelajarCSharp
{
    /*
        Buat variabel var bernama productName dengan nilai Keyboard dan var bernama price dengan nilai 250000m.
        Tampilkan nama, harga, dan tipe data keduanya menggunakan GetType().Name.
    */
    class VarPractice
    {
        public static void JalankanPraktik1()
        {
            var productName = "Keyboard";
            var price = 250000m;

            Console.WriteLine("=== Latihan 1 - var ===\n");

            // Menampilkan nilai
            Console.WriteLine($"Nama Produk : {productName}");
            Console.WriteLine($"Harga       : {price}");

            // Menampilkan tipe data
            Console.WriteLine($"Tipe productName : {productName.GetType().Name}");
            Console.WriteLine($"Tipe price       : {price.GetType().Name}");

            Console.WriteLine();
        }
    }

    /*
    Buat object bernama data dengan nilai 100. Tampilkan nilainya,
    lalu lakukan casting ke int dan tambahkan 50. Tampilkan hasilnya.
    */
    class ObjectPractice
    {
        public static void JalankanPraktik2()
        {
            object data = 100;

            Console.WriteLine("=== Latihan 2 - object ===\n");

            // Menampilkan nilai object
            Console.WriteLine($"Nilai data : {data}");

            // Casting object ke int
            int number = (int)data;

            // Menambahkan 50
            Console.WriteLine($"Hasil setelah + 50 : {number + 50}");

            Console.WriteLine();
        }
    }

    /*
    Buat object bernama value dengan nilai "Belajar C#". Gunakan is untuk memastikan value merupakan string.
    Jika benar, tampilkan panjang teksnya.
    */
    class CheckType
    {
        public static void JalankanPraktik3()
        {
            object value = "Belajar C#";

            Console.WriteLine("=== Latihan 3 - Pemeriksaan tipe ===\n");

            if (value is string text)
            {
                Console.WriteLine($"Teks          : {text}");
                Console.WriteLine($"Panjang teks  : {text.Length}");
            }
            Console.WriteLine();
        }
    }

    /*
    Buat dynamic bernama value dengan nilai "Halo". Tampilkan Length-nya.
    Kemudian ubah nilainya menjadi 200 dan tampilkan hasil value + 50.
    */
    class DynamicPractice
    {
        public static void JalankanPraktik4()
        {
            Console.WriteLine("=== Latihan 4 - Dynamic ===\n");

            dynamic value = "Halo";

            // Karena value berisi string, Length bisa digunakan
            Console.WriteLine($"Panjang teks : {value.Length}");

            // Nilai dynamic diubah menjadi int
            value = 100;

            // Sekarang bisa melakukan operasi matematika
            Console.WriteLine($"Hasil + 50 : {value + 50}");

            Console.WriteLine();
        }
    }

    /*
    Buat tiga variabel: var dengan nilai 10, object dengan nilai 20, dan dynamic dengan nilai 30.
    Tampilkan jumlah ketiganya. Untuk object, lakukan casting yang benar.
    Kemudian ubah nilai dynamic menjadi "Tera" dan tampilkan teksnya.
    */
    class MixPractice
    {
        public static void JalankanPraktik5()
        {
            var nilai = 10;
            object value = 20;
            dynamic data = 30;

            Console.WriteLine("=== Latihan 5 - Gabungan ===\n");

            // casting
            int number = (int)value;

            // Menjumlahkan ketiganya
            int jumlah = nilai + number + data;

            Console.WriteLine($"Jumlah : {jumlah}");

            // Mengubah nilai dynamic menjadi string
            data = "Tera";

            Console.WriteLine($"Data dynamic : {data}");

            Console.WriteLine();
        }
    }

    // ===================================
    // Latihan Lanjutan
    // ===================================

    class DataProduct
    {
        public static void JalankanLatihan1()
        {
            var productName = "Mouse";
            var price = 150000;

            Console.WriteLine("=== Latihan 1 - Data Product ===\n");

            Console.WriteLine($"Nama produk: {productName}");
            Console.WriteLine($"Harga: {price}");

            Console.WriteLine();

            Console.WriteLine(productName.GetType().Name);
            Console.WriteLine(price.GetType().Name);
        }
    }

    class TaxProduct
    {
        public static void JalankanLatihan2()
        {
            object price = 75000;

            Console.WriteLine("=== Latihan 2 - Object dan Casting ===\n");

            // Casting
            int harga = (int)price;

            // Pajak
            int tax = harga * 10 / 100;

            // Total
            int total = harga + tax;

            Console.WriteLine($"Harga       : {harga}");
            Console.WriteLine($"Pajak 10%   : {tax}");
            Console.WriteLine($"Total       : {total}");
        }
    }

    class CheckObject
    {
        public static void JalankanLatihan3()
        {
            object data = "Belajar C#";

            Console.WriteLine("=== Latihan 3 - Mengecek Object ===\n");

            if (data is string text)
            {
                Console.WriteLine("Data adalah string");
                Console.WriteLine($"Panjang : {text.Length}");
            }
            else
            {
                Console.WriteLine("Data bukan string");
            }
        }
    }

    class ChangeType
    {
        public static void JalankanLatihan4()
        {
            dynamic data = 25;

            Console.WriteLine("=== Latihan 4 - Dynamic berubah tipe ===\n");

            Console.WriteLine($"Nilai awal: {data}");
            Console.WriteLine($"Hasil + 10 : {data + 10}");

            data = "Belajar";

            Console.WriteLine($"Nilai baru  : {data}");
            Console.WriteLine($"Panjang     : {data.Length}");
        }
    }

    class MixType
    {
        public static void JalankanLatihan5()
        {
            var angka1 = 10;
            object angka2 = 20;
            dynamic angka3 = 30;

            Console.WriteLine("=== Latihan 5 - Latihan Gabungan ===\n");

            // Casting
            int nilai2 = (int)angka2;

            // jumlah semua
            int jumlah = angka1 + nilai2 + angka3;

            Console.WriteLine($"Jumlah : {jumlah}");

            angka3 = "Belajar C#";

            Console.WriteLine($"Teks: {angka3}");
            Console.WriteLine($"Panjang : {angka3.Length}");
        }
    }
}
