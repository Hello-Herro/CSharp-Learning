using System;
using System.Globalization;

namespace BelajarCSharp
{
    class Praktik_Modul_2_Do_While
    {
        public static void JalankanPraktik1()
        {
            // LATIHAN DO WHILE
            Console.Write("--- Praktik 1 - Cetak angka sampai 5 ---\n");
            /*
            Buat program yang menggunakan do while untuk menghasilkan: 1-5
            */
            int angka = 1;

            do
            {
                Console.WriteLine($"hasil : {angka}");
                angka++;
            } while (angka <= 5);
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 - Input sampai angka 10 ---\n");
            /*
            Buat program yang terus meminta user memasukkan angka.
            Program berhenti hanya jika user memasukkan 10.
            */
            int angka;

            do
            {
                Console.Write("Input angka :    ");

                angka = int.Parse(Console.ReadLine());

                if (angka != 10)
                {
                    Console.WriteLine("Salah! Coba Lagi");
                }
            } while (angka != 10);

            Console.WriteLine("Benar! Program selesai");
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 - Password ---\n");
            /*
            Buat program meminta password.
            Password yang benar:
                admin123
            Program terus meminta password sampai benar.
            Contoh:
            Masukkan password: hello
                Password salah!
                Masukkan password: 12345
            Password salah!
                Masukkan password: admin123
                Password benar!
            Program selesai.
            */
            string password = "admin123";
            string inputPassword;

            do
            {
                Console.Write("Masukkan Password :  ");

                inputPassword = Console.ReadLine();

                if (inputPassword != password)
                {
                    Console.WriteLine("Password salah!");
                }
            } while (inputPassword != password);

            Console.WriteLine("Password benar!\n Program Selesai");
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 - Menu Sederhana ---\n");
            /*
            Buat menu:
            === MENU ===
            1. Nasi Goreng
            2. Mie Goreng
            3. Ayam Goreng
            0. Keluar

            Pilih menu:
                Program terus menampilkan menu sampai user memasukkan:
                0
            */
            string input;

            do
            {
                Console.Write(
                    " === MENU ===\n 1. Nasi Goreng\n 2. Mie Goreng\n 3. Ayam Goreng\n 0. Keluar\n"
                );

                Console.Write("Pilih menu berikut: \n");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Kamu memilih Nasi Goreng");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Kamu memilih Mie Goreng");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Kamu memilih Ayam Goreng");
                }
                else if (input == "0")
                {
                    Console.WriteLine("Terimakasih");
                }
                else
                {
                    Console.WriteLine("Pilihan tidak tersedia");
                }
            } while (input != "0");
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 - Angka Positif ---\n");
            /*
            Buat program yang meminta user memasukkan angka.
            Program terus meminta input selama angka yang dimasukkan kurang dari atau sama dengan 0.
            Jika user memasukkan angka positif, program berhenti.
            */
            int angka;

            do
            {
                Console.Write("Input Angka :    ");
                angka = int.Parse(Console.ReadLine());

                if (angka <= 0)
                {
                    Console.WriteLine("SALAH! Angka Harus Positif");
                    Console.WriteLine();
                }
            } while (angka <= 0);

            Console.WriteLine();
            Console.WriteLine("Angka Valid!");
            Console.WriteLine("Program Selesai");
        }

        public static void JalankanPraktik6()
        {
            Console.Write("--- Praktik 6 - Pilihan Ya/Tidak ---\n");
            /*
            Buat program yang bertanya:
                Apakah kamu ingin melanjutkan? (y/n):
            Program terus bertanya selama user belum memasukkan n.
            */
            string input;

            do
            {
                Console.Write("Apakah kamu ingin melanjutkan? (y/n): ");
                input = Console.ReadLine();

                if (input == "y")
                {
                    Console.WriteLine("Kamu memilih untuk melanjutkan.");
                    Console.WriteLine();
                }
                else if (input != "n") // logika berikut berarti: selain y/n -> input tidak valid
                {
                    Console.WriteLine("Input tidak valid.");
                    Console.WriteLine();
                }
            } while (input != "n");

            Console.WriteLine("Program dihentikan");
        }

        public static void JalankanPraktik7()
        {
            Console.Write("--- Praktik 7 - Tebak Angka ---\n");
            /*
            Buat program dengan angka rahasia:
                int angkaRahasia = 7;
            User terus memasukkan tebakan sampai berhasil menebak 7.
            */
            int angkaRahasia = 7;
            int tebakan;

            do
            {
                Console.WriteLine("Tebak Angka :    ");
                tebakan = int.Parse(Console.ReadLine());

                if (tebakan != angkaRahasia)
                {
                    Console.WriteLine("Salah!");
                    Console.WriteLine();
                }
            } while (tebakan != angkaRahasia);

            Console.WriteLine("Benar!");
            Console.WriteLine("Kamu berhasil menebak angka");
        }

        public static void JalankanPraktik8()
        {
            Console.Write("--- Praktik 8 - Batas Percobaan ---\n");
            /*
            Buat program login dengan:
                Username benar  : Tera
                Password benar  : 12345
            User hanya memiliki 3 kali percobaan.
            */
            string username = "Tera";
            string password = "12345";

            string inputUsername;
            string inputPassword;

            int percobaan = 0;
            bool loginBerhasil = false; // maksud dari ini adalah: "Saya membuat sebuah variabel bernama loginBerhasil yang nilainya hanya bisa benar atau salah."
            // karena 'false' artinya "Untuk saat ini, login belum berhasil." kenapa dibuat false? karena user belum memasukan username & passwordnya
            // jadi kita belum tahu apakah login berhasil.
            /*
                Note:
                Contoh lain:
                    bool sudahBayar = false;
                    bool sedangLogin = true;
                    bool tersedia = true;
                    bool gameSelesai = false;
            */
            do
            {
                percobaan++;

                Console.WriteLine();
                Console.WriteLine($"Percobaan ke-{percobaan}");

                Console.Write("Username : ");
                inputUsername = Console.ReadLine();

                Console.Write("Password : ");
                inputPassword = Console.ReadLine();

                if (inputUsername == username && inputPassword == password)
                {
                    loginBerhasil = true;
                    Console.WriteLine("Login Berhasil!");
                }
                else
                {
                    Console.WriteLine("Login Gagal!");
                }
            } while (!loginBerhasil && percobaan < 3); // dibaca satu-satau, '!loginBerhasil' dibaca "Login belum berhasil" DAN "Jumlah percobaan masih kurang dari 3."
            // jadi dibaca: "Ulangi selama login belum berhasil DAN percobaan masih kurang dari 3."

            if (!loginBerhasil)
            {
                Console.WriteLine("Batas Percobaan Habis!");
                Console.WriteLine("Akun diBlokir");
            }
        }

        public static void JalankanPraktik9()
        {
            Console.Write("--- Praktik 9 - ATM Sederhana ---\n");
            /*
            Buat program saldo:
                decimal saldo = 100000;
            Tampilkan menu:
                === ATM ===
                1. Cek Saldo
                2. Tarik Uang
                3. Keluar
            Pilih:
                Program terus berjalan sampai user memilih 3.
            */
            decimal saldo = 100000m;
            string pilih;

            do
            {
                Console.Write("=== ATM ===\n");
                Console.Write("1. Cek Saldo\n");
                Console.Write("2. Tarik Uang\n");
                Console.Write("3. Keluar\n");

                Console.WriteLine();
                Console.Write("Pilih :  ");
                pilih = Console.ReadLine();

                if (pilih == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Sisa Saldo : {saldo}");
                    Console.WriteLine();
                }
                else if (pilih == "2")
                {
                    Console.Write("Masukkan Jumlah Tarik : ");
                    decimal penarikan = decimal.Parse(Console.ReadLine());

                    if (penarikan <= saldo)
                    {
                        saldo -= penarikan; // ini adalah 'assignment operator', jika kita membuat variable sisa saldo,
                        // maka variable saldo yang awal masih tetap. dan tidak mengubah nilai saldo terbru. karena saldo sendiri harus diperbarui
                        // saldo -= penarikan dapat dibaca: saldo = saldo - penarikan.
                        // contoh lain, x += 5; maka x = x + 5, x *= 5; maka x = x * 5, x -= 5; x = x - 5
                        Console.WriteLine();
                        Console.WriteLine("Penarikan berhasil.");
                        Console.WriteLine($"sisa saldo: Rp.{saldo}");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saldo tidak cukup!");
                        Console.WriteLine();
                    }
                }
                else if (pilih == "3")
                {
                    Console.Write("Terimakasih telah menggunakan ATM");
                }
                else
                {
                    Console.WriteLine("Pilihan tidak tersedia.");
                }
            } while (pilih != "3"); // logika berikut berarti: Ulangi selama user belum memilih 3

            Console.WriteLine("Program selesai.");
        }

        public static void JalankanPraktik10()
        {
            Console.Write("--- Praktik 10 - Menu angka ---\n");
            /*
            buat:
            === MENU ===
            1. Cetak Halo
            2. Cetak Nama
            3. Cetak Umur
            0. Keluar
            Gunakan do while.
            Program berhenti jika:
                0
            */
            string halo = "Halo";
            string nama = "Tera";
            int umur = 25;
            string pilih;

            do
            {
                Console.Write("=== MENU ===\n");
                Console.Write("1. Cetak Halo\n");
                Console.Write("2. Cetak Nama\n");
                Console.Write("3. Cetak Umur\n");
                Console.Write("0. Keluar\n");

                Console.Write("Pilih :  ");
                Console.WriteLine();
                pilih = Console.ReadLine();

                if (pilih == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cetak : {halo}");
                    Console.WriteLine();
                }
                else if (pilih == "2")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cetak : {nama}");
                    Console.WriteLine();
                }
                else if (pilih == "3")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Cetak : {umur}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Pilihan tidak tersedia.");
                }
            } while (pilih != "0");
            Console.WriteLine();
            Console.WriteLine("Program Berhenti");
            Console.WriteLine();
        }

        public static void JalankanPraktik11()
        {
            Console.Write("--- Praktik 11 - Penjumlahan berulang ---\n");
            /*
            Program meminta angka terus-menerus.
            Setiap angka ditambahkan ke total.
            Jika user memasukkan 0, berhenti.

            Petunjuk:
            Kamu membutuhkan:
                int angka = 0;
                int total = 0;
            dan setiap kali input:
                total = total + angka
            */
            int angka = 0;
            int total = 0;

            do
            {
                Console.Write("Masukan angka : ");
                angka = int.Parse(Console.ReadLine());

                if (angka != 0)
                {
                    total += angka;
                    Console.WriteLine($"Total sementara : {total}");
                    Console.WriteLine();
                }
            } while (angka != 0);

            Console.WriteLine();
            Console.WriteLine($"Total Akhir : {total}");
        }

        public static void JalankanPraktik12()
        {
            Console.Write("--- Praktik 12 - Tabak angka + petunjuk  ---\n");
            /*
            buat program tebak Angka rahasia:
                int angkaRahasia = 50;
            User terus menebak.
            Kalau tebakan terlalu kecil:
                Terlalu kecil!
            Kalau terlalu besar:
                Terlalu besar!
            Kalau benar:
                Benar! Kamu berhasil!
            */
            int angkaRahasia = 50;
            int input;

            do
            {
                Console.Write("Tebak Angka :    ");
                input = int.Parse(Console.ReadLine());

                if (input < angkaRahasia)
                {
                    Console.WriteLine("terlalu kecil");
                    Console.WriteLine();
                }
                else if (input > angkaRahasia)
                {
                    Console.WriteLine("terlalu besar");
                    Console.WriteLine();
                }
            } while (input != angkaRahasia);

            Console.WriteLine("Benar! Kamu berhasil!");
            Console.WriteLine();
        }
    }
}
