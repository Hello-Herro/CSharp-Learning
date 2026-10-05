using System;

namespace BelajarCSharp
{
    class Praktik_Modul_3_Array
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Praktik 1 - Array + for ---\n");
            /*
            Buat array integer:
            10
            20
            30
            40
            50
            Kemudian tampilkan:
                Nilai index 0: 10
                Nilai index 1: 20
                Nilai index 2: 30
                Nilai index 3: 40
                Nilai index 4: 50
            Syarat:
            Gunakan:
                array
                for
                .Length
            jangan tulis manual:
            Console.WriteLine(angka[0]);
            Console.WriteLine(angka[1]);
            ...
            */
            int[] angka = { 10, 20, 30, 40, 50 };

            for (int i = 0; i < angka.Length; i++)
            {
                // Console.WriteLine(angka[i]);
                Console.WriteLine($"Nilai index {i}: {angka[i]}");
            }
            Console.WriteLine();
            // Console.WriteLine(angka.Length);
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Praktik 2 - Array + foreach ---\n");
            /*
            Gunakan array yang sama:
            10, 20, 30, 40, 50
            Tampilkan semua nilai menggunakan foreach.
            Target:
            10
            20
            30
            40
            50
            */
            int[] angka = { 10, 20, 30, 40, 50 };

            foreach (int nilai in angka) // Cara membacanya: Untuk setiap nilai yang ada di dalam angka, tampilkan nilai.
            {
                Console.WriteLine(nilai);
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Praktik 3 - Cari nilai tertentu ---\n");
            /*
            Gunakan array yang sama:
            10, 20, 30, 40, 50
            cari angka: 40
            Target:
            angka 40 ditemukan.
            gunakan foreach + if
            */
            int[] angka = { 10, 20, 30, 40, 50 };

            foreach (int nilai in angka)
            {
                if (nilai == 40)
                {
                    Console.WriteLine($"angka {nilai} ditemukan");
                }
                // else
                // {
                //     Console.WriteLine("Invalid!");
                // }
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Praktik 4 - Total Array ---\n");
            /*
            Gunakan:
            int[] angka = { 10, 20, 30, 40, 50 };
            Hitung total:
            Total: 150
            Gunakan konsep accumulator yang sudah kita pelajari:
            total += nilai;
            */
            int[] angka = { 10, 20, 30, 40, 50 };

            // Nilai awal accumulator
            int total = 0;

            foreach (int nilai in angka)
            {
                total += nilai;

                // Tampilkan hasil akhir setelah loop selesai
                Console.WriteLine($"total: {total}"); // didalam loop proses setiap data
            }
            Console.WriteLine();
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Praktik 5 - Tantangan ---\n");
            /*
            Gunakan:
            int[] angka = { 10, 75, 30, 90, 45, 60 };
            Tampilkan hanya angka yang lebih besar dari 50.
            Target:
                75
                90
                60
            Gunakan:
                foreach
                +
                if
            */
            int[] angka = { 10, 75, 30, 90, 45, 60 };

            foreach (int nilai in angka)
            {
                if (nilai > 50)
                {
                    Console.WriteLine(nilai);
                }
            }
            Console.WriteLine();
        }
    }

    class Praktik_Modul_3_Array_2_Dimensi
    {
        public static void JalankanPraktik1()
        {
            Console.Write("--- Latihan 1 - Array 2 Dimensi ---\n");

            int[,] numbers = new int[3, 3];

            numbers[0, 0] = 1;
            numbers[0, 1] = 2;
            numbers[0, 2] = 3;

            numbers[1, 0] = 4;
            numbers[1, 1] = 5;
            numbers[1, 2] = 6;

            numbers[2, 0] = 7;
            numbers[2, 1] = 8;
            numbers[2, 2] = 9;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(numbers[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void JalankanPraktik2()
        {
            Console.Write("--- Latihan 2 - Menampilkan Index ---\n");

            int[,] angka = new int[3, 4];

            angka[0, 0] = 1;
            angka[0, 1] = 2;
            angka[0, 2] = 3;
            angka[0, 3] = 4;
            angka[1, 0] = 5;
            angka[1, 1] = 6;
            angka[1, 2] = 7;
            angka[1, 3] = 8;
            angka[2, 0] = 9;
            angka[2, 1] = 10;
            angka[2, 2] = 11;
            angka[2, 3] = 12;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.WriteLine("angka[" + row + "," + col + "] = " + angka[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void JalankanPraktik3()
        {
            Console.Write("--- Latihan 3 - Jumlah seluruh elemen ---\n");

            int[,] angka =
            {
                { 10, 20, 30 },
                { 40, 50, 60 },
                { 70, 80, 90 },
            };

            int total = 0;

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    total = total + angka[row, col];
                }
            }
            Console.WriteLine("Jumlah seluruh elemen = " + total);
            Console.WriteLine();
        }

        public static void JalankanPraktik4()
        {
            Console.Write("--- Latihan 4 - mencari angka terbesar ---\n");

            int[,] angka =
            {
                { 12, 45, 7 },
                { 89, 23, 56 },
                { 34, 91, 18 },
            };

            int terbesar = angka[0, 0];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (angka[row, col] > terbesar)
                    {
                        terbesar = angka[row, col];
                    }
                }
            }
            Console.WriteLine("Angka terbesar = " + terbesar);
            Console.WriteLine();
        }

        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public static void JalankanPraktik5()
        {
            Console.Write("--- Latihan 5 - Array Object Student ---\n");

            Student[,] students = new Student[2, 2];

            students[0, 0] = new Student();
            students[0, 0].Name = "Tera";
            students[0, 0].Age = 20;

            students[0, 1] = new Student();
            students[0, 1].Name = "Alex";
            students[0, 1].Age = 21;

            students[1, 0] = new Student();
            students[1, 0].Name = "John";
            students[1, 0].Age = 22;

            students[1, 1] = new Student();
            students[1, 1].Name = "Maria";
            students[1, 1].Age = 20;

            for (int row = 0; row < 2; row++)
            {
                for (int number = 0; number < 2; number++)
                {
                    Console.WriteLine(
                        "students["
                            + row
                            + ","
                            + number
                            + "] = "
                            + students[row, number].Name
                            + " - "
                            + students[row, number].Age
                    );
                }
            }
            Console.WriteLine();
        }

        class Studentt
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }

        public static void JalankanPraktik6()
        {
            Console.Write("--- Latihan 6 - Array Object dengan kondisi ---\n");
            Console.Write("Tampilkan hanya mahasiswa yang memiliki Score >= 75!\n");

            Studentt[,] students = new Studentt[2, 3];

            students[0, 0] = new Studentt();
            students[0, 0].Name = "Tera";
            students[0, 0].Score = 90;

            students[0, 1] = new Studentt();
            students[0, 1].Name = "Alex";
            students[0, 1].Score = 50;

            students[0, 2] = new Studentt();
            students[0, 2].Name = "John";
            students[0, 2].Score = 80;

            students[1, 0] = new Studentt();
            students[1, 0].Name = "Maria";
            students[1, 0].Score = 75;

            students[1, 1] = new Studentt();
            students[1, 1].Name = "Samara";
            students[1, 1].Score = 85;

            students[1, 2] = new Studentt();
            students[1, 2].Name = "Doni";
            students[1, 2].Score = 65;

            for (int row = 0; row < 2; row++)
            {
                for (int number = 0; number < 3; number++)
                {
                    if (students[row, number].Score >= 75)
                    {
                        Console.Write(
                            "students["
                                + row
                                + ","
                                + number
                                + "] = "
                                + students[row, number].Name
                                + " - "
                                + students[row, number].Score
                        );
                    }
                    Console.WriteLine();
                }
            }
        }

        enum SeatStatus
        {
            Vacant,
            Booked,
        }

        class Seat
        {
            public int Row { get; set; }
            public int Number { get; set; }
            public SeatStatus Status { get; set; }
        }

        public static void JalankanPraktik7()
        {
            Console.Write("--- Latihan 7 - membuat InitializeSeats() ---\n");

            Seat[,] seats = new Seat[3, 4];
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    seats[row, col] = new Seat();

                    seats[row, col].Row = row + 1;
                    seats[row, col].Number = col + 1;
                    seats[row, col].Status = SeatStatus.Vacant;
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.WriteLine(
                        "Row: "
                            + seats[row, col].Row
                            + " | Seat: "
                            + seats[row, col].Number
                            + " | Status: "
                            + seats[row, col].Status
                    );
                }
            }
        }

        public static void JalankanPraktik8()
        {
            Console.Write("--- Latihan 8 - Booking sederhana ---\n");
        }
    }
}
