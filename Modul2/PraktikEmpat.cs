using System;

namespace BelajarCSharp
{
    class Praktik_Modul_2_Exception_Handling
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 - try-catch sederhana ---\n");
            /*
            Buat program:
                Masukkan angka:
            Gunakan:
                int.Parse()
                di dalam try.
            Kalau user memasukkan angka:
                25
            output:
                Angka kamu: 25
            Kalau user memasukkan:
                abc
            output:
                Input tidak valid.
            */
            try
            {
                Console.Write("Masukkan angka : ");
                int angka = int.Parse(Console.ReadLine());

                Console.WriteLine($"Angka kamu : {angka}");
            }
            catch
            {
                Console.WriteLine("Input tidak valid");
            }
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 - Tampilkan Exception.Message ---\n");
            /*
            Buat program yang mencoba:
                int angka = int.Parse("abc");
            Gunakan:
                catch (Exception exception)
            dan tampilkan:
                Terjadi error:
            diikuti:
                exception.Message
            */
            try
            {
                int angka = int.Parse("abc");
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Terjadi error : {exception.Message}");
            }
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 - Try-catch-finally ---\n");
            /*Buat input angka menggunakan int.Parse().
            Ketentuan:
                try
                    → coba membaca angka

                catch
                    → "Input tidak valid."

                finally
                    → "Program selesai."
            Kalau input valid maupun invalid, Program selesai. harus tetap muncul.
            */
            try
            {
                Console.Write("Masukkan angka : ");
                int angka = int.Parse(Console.ReadLine());

                Console.WriteLine("Input Valid");
            }
            catch
            {
                Console.WriteLine("Input Tidak Valid");
            }
            finally
            {
                Console.WriteLine("Program selesai");
            }
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 - DivideByZeroException ---\n");
            /*
            Buat program:
                Masukkan angka pertama:
                Masukkan angka kedua:
            Kemudian:
                hasil = angkaPertama / angkaKedua;
            Gunakan try-catch.
            Kalau user memasukkan:
                10
                2
            output:
                Hasil: 5, kalau 10/0 menghasilkan: tangani error tersebut dan tampilkan pesan yang sesuai.
            */
            try
            {
                Console.Write("Masukkan angka pertama : ");
                int angkaPertama = int.Parse(Console.ReadLine());
                Console.Write("Masukkan angka kedua : ");
                int angkaKedua = int.Parse(Console.ReadLine());

                int hasil = angkaPertama / angkaKedua;

                Console.WriteLine($"Hasil Sesuai dan Valid: {hasil}");
            }
            catch (DivideByZeroException)
            {
                // Console.WriteLine($"Terjadi error : {exception.Message}");
                Console.WriteLine("Tidak boleh melakukan pembagian dengan angka 0"); // secara eksplisit mengatakan : "Kalau error-nya adalah pembagian dengan nol,
                // tangani dengan cara ini."
            }
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 - Gabungan input + exception ---\n");
            /*
            Buat program:
                Masukkan umur:
                Gunakan int.Parse() dalam try.
            Kalau berhasil:
                Umur kamu: 25
            Kalau gagal:
                Umur harus berupa angka.
            Kemudian gunakan finally:
                Proses input selesai.
            */
            try
            {
                Console.Write("Masukkan umur : ");
                int umur = int.Parse(Console.ReadLine());

                Console.WriteLine($"Umur kamu : {umur}");
            }
            catch
            {
                Console.WriteLine("Umur harus berupa angka");
            }
            finally
            {
                Console.WriteLine("Program input selesai");
            }
        }

        public static void JalankanPraktik6()
        {
            Console.Write("--- Praktik 6 - Specific exception ---\n");
            /*
            Buat program:
                Masukkan angka pertama:
                Masukkan angka kedua:
            Lakukan pembagian.
            Tangani dua jenis error:
                Input bukan angka
            Contoh:
            Masukkan angka pertama: abc
            Output:
                Input harus berupa angka.
            Gunakan:
                catch (FormatException)
            */
            try
            {
                Console.Write("Masukkan angka pertama : ");
                int angkaPertama = int.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua : ");
                int angkaKedua = int.Parse(Console.ReadLine());

                int pembagian = angkaPertama / angkaKedua;

                Console.WriteLine($"hasil pembagian : {pembagian}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input harus berupa angka");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("angka kedua tidak boleh 0");
            }
        }

        public static void JalankanPraktik7()
        {
            Console.Write("--- Praktik 7 - Specific + General Exception ---\n");
            /*
            Buat program dengan:
                try
                catch (FormatException)
                catch (DivideByZeroException)
                catch (Exception)
            Ketentuannya:
            FormatException
                → "Input harus berupa angka."

            DivideByZeroException
                → "Tidak boleh membagi dengan 0."

            Exception
                → "Terjadi error yang tidak diketahui."
            */
            try
            {
                Console.Write("Masukkan angka pertama : ");
                int angkaPertama = int.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua : ");
                int angkaKedua = int.Parse(Console.ReadLine());

                int pembagian = angkaPertama / angkaKedua;

                Console.WriteLine($"hasil pembagian : {pembagian}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input harus berupa angka.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Tidak boleh membagai dengan 0.");
            }
            catch (Exception)
            {
                Console.WriteLine("Terjadi error yang tidak diketahui.");
            }
        }

        public static void JalankanPraktik8()
        {
            Console.Write("--- Praktik 8 - Finally ---\n");
            /*
            Buat kalkulator pembagian seperti Praktik 6.
            Kali ini tambahkan:
                finally
                {
                    Console.WriteLine("Proses pembagian selesai.");
                }
            Coba jalankan dengan:
            Test 1
            10
            2
            Test 2
            10
            0
            Test 3
            abc
            2
            */
            try
            {
                Console.Write("Masukkan angka pertama : ");
                int angkaPertama = int.Parse(Console.ReadLine());

                Console.Write("Masukkan angka kedua : ");
                int angkaKedua = int.Parse(Console.ReadLine());

                int pembagian = angkaPertama / angkaKedua;

                Console.WriteLine($"hasil pembagian : {pembagian}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input harus berupa angka");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("angka kedua tidak boleh 0");
            }
            finally
            {
                Console.WriteLine("Proses pembagian selesai.");
            }
        }

        public static void JalankanPraktik9()
        {
            Console.Write("--- Praktik 9 - Exception Filter When ---\n");
            /*
            Buat program sederhana:
                try
                {
                    int angka = int.Parse("abc");
                }
                catch (FormatException exception)
                    when (...)
                {
                    ...
                }
            Gunakan when sebagai filter.
            Target:
            Input memiliki format yang salah.
            Untuk latihan ini kamu boleh menggunakan:
                exception.Message
            sebagai kondisi when, karena tujuan kita adalah memahami syntax dan konsep exception filter.
            */
            try
            {
                int angka = int.Parse("abc");
            }
            catch (FormatException exception) // Cara membacanya: "Tangkap FormatException,
                when (exception.Message == "Input string was not in a correct format.") // tetapi hanya kalau kondisi when terpenuhi."
            {
                Console.WriteLine("input tidak sesuai format.");
            }
        }

        public static void JalankanPraktik10()
        {
            Console.Write("--- Praktik 10 - Tantangan ---\n");
            /*
            Buat program kalkulator sederhana:
                Masukkan angka pertama:
                Masukkan operator (+ atau - atau * atau /):
                Masukkan angka kedua:
            Contoh:
                Masukkan angka pertama: 10
                Operator: /
                Masukkan angka kedua: 2
                Hasil: 5
            Gunakan:
                try
                catch
                finally
            dan switch untuk operator.
            Tangani:
                FormatException
                DivideByZeroException
                Exception
            Target jika input:
                10
                /
                0
            adalah:
                Tidak boleh membagi dengan 0.
                Dan finally tetap menampilkan:
                Proses kalkulator selesai.
            */
            try
            {
                Console.Write("Masukkan angka pertama : ");
                int angkaPertama = int.Parse(Console.ReadLine());

                Console.Write("Masukkan Operator (+, -, *, /) : ");
                string operatorInput = Console.ReadLine();

                Console.Write("Masukkan angka kedua : ");
                int angkaKedua = int.Parse(Console.ReadLine());

                switch (operatorInput)
                {
                    case "+":
                        Console.WriteLine($"Hasil : {angkaPertama + angkaKedua}");
                        break;

                    case "-":
                        Console.WriteLine($"Hasil : {angkaPertama - angkaKedua}");
                        break;

                    case "*":
                        Console.WriteLine($"Hasil : {angkaPertama * angkaKedua}");
                        break;

                    case "/":
                        int hasil = angkaPertama / angkaKedua;

                        Console.WriteLine($"Hasil : {hasil}");
                        break;

                    default:
                        Console.WriteLine("Operator tidak valid.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input harus berupa angka");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("angka kedua tidak boleh 0");
            }
            catch (Exception)
            {
                Console.WriteLine("Terjadi error yang tidak diketahui.");
            }
            finally
            {
                Console.WriteLine("Proses kalkulator selesai.");
            }
        }
    }
}
