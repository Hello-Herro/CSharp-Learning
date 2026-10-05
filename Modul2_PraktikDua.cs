using System;
using System.Globalization;

namespace BelajarCSharp
{
    class Praktik_Modul_2_Loop
    {
        public static void JalankanVersi1()
        {
            #region For
            Console.Write("--- Praktik 1 For ---\n");
            // buat program yang menghasilkan output 1-10 menggunakan For
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion
        }

        public static void JalankanVersi2()
        {
            #region For mundur
            Console.Write("--- Praktik 2 For Mundur ---\n");            
            // buat program yang menhasilkan output 10-1 menggunakan For
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            #endregion
        }

        public static void JalankanVersi3()
        {
            #region While
            Console.Write("--- Praktik 3 While ---\n");
            // buat program yang menghasilkan output 1-5 menggunakan While
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);

                i++;
            }
            #endregion
        }

        public static void JalankanVersi4()
        {
            #region Do While
            Console.Write("--- Praktik 4 Do While ---\n");            
            /*
            Buat program yang meminta user memasukkan angka.
                Program terus meminta angka selama angka yang dimasukkan bukan 10.
            Contoh:
                Masukkan angka: 3
                Salah!

                Masukkan angka: 7
                Salah!

                Masukkan angka: 10
                Benar! Program selesai.
            */
            int angka;

            do
            {
                Console.Write("Masukkan Angka : ");
                angka  = int.Parse(Console.ReadLine());

                if (angka != 10)
                {
                    Console.WriteLine("Salah!");
                }

            } while (angka != 10);
            // cara baca: Lakukan dulu, kemudian cek apakah angka masih bukan 10.
            Console.WriteLine("Benar! Program Selesai");

            #endregion
        }

        public static void JalankanVersi5()
        {
            #region Foreach
            Console.Write("--- Praktik 5 Foreach ---\n");            
            /*
            Buat array:
            string[] nama =
            {
                "Tera",
                "Budi",
                "Andi",
                "Sinta"
            };
            Tampilkan semua nama menggunakan:
            foreach
            */
            string[] nama = { "Tera", "Budi", "Andi", "Sinta" };

            foreach (string item in nama)       // Cara membacanya: Untuk setiap item bertipe string yang ada di dalam nama, lakukan sesuatu.
            {
                Console.WriteLine(item);
            }
            #endregion
        }

        public static void JalankanVersi6()
        {
            #region Nested Loop
            Console.Write("--- Praktik 6 Nested Loop ---\n");
            /*
            Buat output:
            1 1
            1 2
            1 3
            2 1
            2 2
            2 3
            3 1
            3 2
            3 3
            Gunakan nested for loop.
            */
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    // Console.WriteLine($"i = {i}, j = {j}");
                    Console.WriteLine($"{i} {j}");
                }
            }
            // Note: Jadi:  1 kali loop luar (i) → seluruh loop dalam (j) dijalankan sampai selesai.
            #endregion
        }
    }
}
