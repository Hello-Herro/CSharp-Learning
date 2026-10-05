using System;
using System.Globalization;

namespace BelajarCSharp
{
    class Praktik_Modul_2
    {
        public static void JalankanVersi1()
        {
            #region IF ... ELSE
            // Praktik 1 - Cek Umur
            /*
            Buat program:
                Masukkan umur: 20
            Output:
                Kamu sudah dewasa.
            Jika umur di bawah 18:
                Masukkan umur: 15
            Output:
                Kamu belum dewasa.
            Gunakan:
                if
                else
            */
            Console.Write("--- Praktik 1 Cek Umur ---\n");
            Console.Write("Masukkan Umur :  ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 18)
            {
                Console.WriteLine("Kamu Sudah Dewasa");
            }
            else
            {
                Console.WriteLine("Kamu Belum Dewasa");
            }
            #endregion
        }

        public static void JalankanVersi2()
        {
            #region IF ... ELSE IF ... ELSE
            // Praktik 2 - Nilai Ujian
            /*
            Buat program yang menerima nilai:
                90 - 100 → Sangat Baik
                80 - 89  → Baik
                70 - 79  → Cukup
                < 70     → Perlu Belajar Lagi
            Gunakan:
                if
                else if
                else
            */
            Console.Write("--- Praktik 2 Nilai Ujian ---\n");
            Console.Write("Masukkan Nilai Ujian Anda :  ");
            int nilai = int.Parse(Console.ReadLine());

            if (nilai >= 90)
            {
                Console.WriteLine("Sangat Baik");
            }
            else if (nilai >= 80 && nilai <= 89) // Artinya: Nilai harus minimal 80 DAN maksimal 89.
            {
                Console.WriteLine("Baik");
            }
            else if (nilai >= 70 && nilai <= 79)
            {
                Console.WriteLine("Cukup");
            }
            else
            {
                Console.WriteLine("Perlu Belajar Lagi!");
            }
            // Note : cara lebih sederhana, karea IF diperiksa dari atas kebawah  cukup if (nilai >= 90), if (nilai >= 80), if (nilai >= 70)
            // karena Kalau gagal, berarti nilai sudah pasti di bawah 90.
            #endregion
        }

        public static void JalankanVersi3()
        {
            #region IF ... String
            // Praktik 3 - Login Sederhana
            /*
            Buat:
                string username = "Tera";
                string password = "12345";
            Kemudian minta user memasukkan username dan password.
            Jika keduanya benar:
                Login berhasil.
            Jika salah:
                Username atau password salah.
            Gunakan:
                &&
                if
                else
            */
            Console.Write("--- Praktik 3 Login Sederhana ---\n");
            Console.Write("Masukkan username dan Password : ");
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            if (username == "Tera" && password == "12345")
            {
                Console.WriteLine("Login Berhasil");
            }
            else
            {
                Console.Write("Username atau Password Salah");
            }
            #endregion
            // Atau
            string username1 = "Tera";
            string password1= "12345";

            Console.Write("Masukkan username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Masukkan password: ");
            string inputPassword = Console.ReadLine();

            if (inputUsername == username1 && inputPassword == password1)
            {
                Console.WriteLine("Login Berhasil");
            }
            else
            {
                Console.WriteLine("Username atau Password Salah");
            }
        }

        public static void JalankanVersi4()
        {
            #region Switch
            // Praktik 4 - Menu Minuman
            /*
            Buat menu:
                1. Kopi
                2. Teh
                3. Jus
                4. Air Mineral
            User memasukkan pilihan.
            Gunakan switch.
            Contoh:
                Pilih minuman: 2
            Output:
                Kamu memilih Teh.
            Jika input selain 1–4:
                Pilihan tidak tersedia.
            */
            Console.Write("--- Praktik 4 Menu minuman ---\n");
            Console.Write(
                "Pilih Menu : 1. Kopi, 2. Teh, 3. Jus, 4. Air Mineral \n mau pilih apa? "
            );
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Kamu memilih Kopi");
                    break;
                case "2":
                    Console.WriteLine("Kamu memilih Teh");
                    break;
                case "3":
                    Console.WriteLine("Kamu memilih Jus");
                    break;
                case "4":
                    Console.WriteLine("Kamu memilih Air Mineral");
                    break;
                default:
                    Console.WriteLine("Pilihan tidak tersedia");
                    break;
            }
            // Note : kalau menggunakan 'int input', maka 'case 1' bukan 'case "1"'
            #endregion
        }

        public static void JalankanVersi5()
        {
            #region Ternary
            // Praktik 5 - Ternary
            /*
            Buat:
                Masukkan umur: 20
            Output:
                Status: Dewasa
            Gunakan ternary operator ?:, bukan if.
            */
            Console.Write("--- Praktik 5 Ternary ---\n");
            Console.Write("Masukkan umur :  ");
            int umur = int.Parse(Console.ReadLine());

            string status = umur >= 18 ? "Dewasa" : "Belum Dewasa";

            Console.WriteLine(status);
            #endregion
        }
    }
}
