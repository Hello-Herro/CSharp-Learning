using System;

namespace BelajarCSharp
{
    // =========================================================
    // LATIHAN 1 - INTERFACE
    // =========================================================

    public interface IPrintable
    {
        void Print();
    }

    public class Document : IPrintable
    {
        public void Print()
        {
            Console.WriteLine(
                "Dokumen sedang dicetak."
            );
        }
    }


    // =========================================================
    // LATIHAN 2 - INTERFACE + 2 CLASS
    // =========================================================

    public interface IAnimal
    {
        void MakeSound();
    }

    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }


    // =========================================================
    // LATIHAN 3 - ABSTRACT CLASS
    // =========================================================

    public abstract class Employei
    {
        public string Name { get; set; }

        public abstract void Work();

        public void DisplayName()
        {
            Console.WriteLine($"Nama: {Name}");
        }
    }

    public class Manager : Employei
    {
        public override void Work()
        {
            Console.WriteLine(
                "Manager sedang mengatur tim."
            );
        }
    }

    public class Developer : Employei
    {
        public override void Work()
        {
            Console.WriteLine(
                "Developer sedang membuat program."
            );
        }
    }

    public class Designer : Employei
    {
        public override void Work()
        {
            Console.WriteLine(
                "Designer sedang membuat desain."
            );
        }
    }


    // =========================================================
    // LATIHAN 4 - ABSTRACT CLASS + INTERFACE
    // =========================================================

    public interface IMovable
    {
        void Move();
    }

    public abstract class Vehicle
    {
        public string Brand { get; set; }

        public abstract void Start();
    }

    public class Car : Vehicle, IMovable
    {
        public override void Start()
        {
            Console.WriteLine(
                "Mesin mobil menyala."
            );
        }

        public void Move()
        {
            Console.WriteLine(
                "Mobil bergerak."
            );
        }
    }

    public class Motorcycle : Vehicle, IMovable
    {
        public override void Start()
        {
            Console.WriteLine(
                "Mesin motor menyala."
            );
        }

        public void Move()
        {
            Console.WriteLine(
                "Motor bergerak."
            );
        }
    }


    // =========================================================
    // LATIHAN 5 - GABUNGAN
    // =========================================================

    public interface IPerson
    {
        string Name { get; set; }

        void DisplayInfo();
    }

    public interface IWorker
    {
        void Work();
    }

    public abstract class EmployeeBase
    {
        public int EmployeeId { get; set; }

        public decimal Salary { get; set; }

        public decimal CalculateAnnualSalary()
        {
            return Salary * 12;
        }

        public abstract void EmployeeInformation();
    }

    public class Manajer : EmployeeBase, IPerson, IWorker
    {
        public string Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine(
                "Manager di PT. Indocyber Global Teknologi."
            );
        }

        public void Work()
        {
            Console.WriteLine(
                "Mengatur jadwal dengan client."
            );
        }

        public override void EmployeeInformation()
        {
            Console.WriteLine(
                "Bekerja dengan jujur dan ceria."
            );
        }
    }


    // =========================================================
    // POLYMORPHISM - LATIHAN 1
    // =========================================================

    public abstract class Animal
    {
        public abstract void MakeSound();
    }

    public class Catt : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Dogg : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }
    }


    // =========================================================
    // POLYMORPHISM - LATIHAN 2
    // =========================================================

    public static class AnimalHelper
    {
        public static void PlaySound(Animal animal)
        {
            animal.MakeSound();
        }
    }


    // =========================================================
    // POLYMORPHISM - LATIHAN 3
    // =========================================================

    public class Carr : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Mobil bergerak.");
        }
    }

    public class Motorcyclee : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Motor bergerak.");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Sepeda bergerak.");
        }
    }


    // =========================================================
    // POLYMORPHISM - LATIHAN 5
    // Overloading + Overriding
    // =========================================================

    public class Calculator
    {
        // Overload 1
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overload 2
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overload 3
        public double Add(double a, double b)
        {
            return a + b;
        }
    }


    // Parent
    public abstract class EmployeeNew
    {
        public abstract void Work();
    }


    // Child 1
    public class Manazer : EmployeeNew
    {
        public override void Work()
        {
            Console.WriteLine(
                "Manajer sedang bekerja."
            );
        }
    }


    // Child 2
    public class Develover : EmployeeNew
    {
        public override void Work()
        {
            Console.WriteLine(
                "Developer sedang bekerja."
            );
        }
    }
}