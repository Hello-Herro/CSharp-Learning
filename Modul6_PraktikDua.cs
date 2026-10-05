using System;

namespace BelajarCSharp
{
    // contoh penting materi Struct & Reference
    class Personnn
    {
        public string Name { get; set; }
    }

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void ChangeInt(int number)
        {
            number = 100;
        }

        static void ChangePoint(Point point)
        {
            point.X = 100;
        }

        static void ChangePersonnn(Personnn personnn)
        {
            personnn.Name = "Budi";
        }

        static void ReplacePersonnn(Personnn personnn)
        {
            personnn = new Personnn();

            personnn.Name = "Andi";
        }

        static void ChangeIntWithRef(ref int number)
        {
            number = 100;
        }

        static void Main()
        {
            // -----------------------------
            // VALUE TYPE
            // -----------------------------

            int a = 10;
            int b = a;

            b = 20;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Console.WriteLine();

            // -----------------------------
            // STRUCT
            // -----------------------------

            Point p1 = new Point();

            p1.X = 10;
            p1.Y = 20;

            Point p2 = p1;

            p2.X = 100;

            Console.WriteLine($"p1.X = {p1.X}");
            Console.WriteLine($"p2.X = {p2.X}");

            Console.WriteLine();

            // -----------------------------
            // REFERENCE TYPE
            // -----------------------------

            Personnn personnn1 = new Personnn();

            personnn1.Name = "Tera";

            Personnn personnn2 = personnn1;

            personnn2.Name = "Budi";

            Console.WriteLine($"personnn1.Name = {personnn1.Name}");

            Console.WriteLine($"personnn2.Name = {personnn2.Name}");

            Console.WriteLine();

            // -----------------------------
            // METHOD + VALUE TYPE
            // -----------------------------

            int x = 10;

            ChangeInt(x);

            Console.WriteLine($"x setelah ChangeInt = {x}");

            Console.WriteLine();

            // -----------------------------
            // METHOD + STRUCT
            // -----------------------------

            Point point = new Point();

            point.X = 10;

            ChangePoint(point);

            Console.WriteLine($"point.X setelah ChangePoint = {point.X}");

            Console.WriteLine();

            // -----------------------------
            // METHOD + CLASS
            // -----------------------------

            Personnn personnn3 = new Personnn();

            personnn3.Name = "Tera";

            ChangePersonnn(personnn3);

            Console.WriteLine($"personnn3.Name = {personnn3.Name}");

            Console.WriteLine();

            // -----------------------------
            // REPLACE REFERENCE
            // -----------------------------

            Personnn personnn4 = new Personnn();

            personnn4.Name = "Tera";

            ReplacePersonnn(personnn4);

            Console.WriteLine($"personnn4.Name = {personnn4.Name}");

            Console.WriteLine();

            // -----------------------------
            // REF
            // -----------------------------

            int number = 10;

            ChangeIntWithRef(ref number);

            Console.WriteLine($"number setelah ref = {number}");
        }
    }

    // =========================================================
    // LATIHAN 1 - STRUCT / VALUE TYPE
    // =========================================================

    public struct ProductValue
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    // =========================================================
    // LATIHAN 2 - CLASS / REFERENCE TYPE
    // =========================================================

    public class ProductReference
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    // =========================================================
    // LATIHAN 5 - VALUE TYPE
    // =========================================================

    public struct StudentValue
    {
        public string Name { get; set; }
    }

    // =========================================================
    // LATIHAN 5 - REFERENCE TYPE
    // =========================================================

    public class StudentReference
    {
        public string Name { get; set; }
    }

    // =========================================================
    // HELPER UNTUK LATIHAN
    // =========================================================

    public static class StructHelper
    {
        // -----------------------------------------------------
        // Latihan 3 - Value Type
        // -----------------------------------------------------

        public static void ChangeNumber(int number)
        {
            number = 14;
        }

        // -----------------------------------------------------
        // Latihan 3 - Struct
        // -----------------------------------------------------

        public static void ChangeStruct(ProductValue product)
        {
            product.Name = "BengBeng";
        }

        // -----------------------------------------------------
        // Latihan 3 - Reference Type
        // -----------------------------------------------------

        public static void ChangeProduct(ProductReference product)
        {
            product.Name = "Nutrisari";
        }

        // -----------------------------------------------------
        // Latihan 4 - ref
        // -----------------------------------------------------

        public static void ChangeNumber(ref int number)
        {
            number = 100;
        }

        // -----------------------------------------------------
        // Latihan 5 - Value vs Reference
        // -----------------------------------------------------

        public static void ChangeStudent(
            StudentValue valueStudent,
            StudentReference referenceStudent
        )
        {
            valueStudent.Name = "Budi";

            referenceStudent.Name = "Andi";
        }
    }
}
