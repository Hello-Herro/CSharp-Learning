using System;
using System.Globalization;
using BelajarCSharp;

// // =========================================================
// // Latihan 1 - Interface
// // =========================================================

// Console.WriteLine("=== Latihan 1 - Interface ===");

// Document doc = new Document();

// doc.Print();

// Console.WriteLine();

// // =========================================================
// // Latihan 2 - Interface + 2 Class
// // =========================================================

// Console.WriteLine(
//     "=== Latihan 2 - Interface + 2 Class ==="
// );

// Cat cat = new Cat();

// cat.MakeSound();

// Dog dog = new Dog();

// dog.MakeSound();

// Console.WriteLine();

// // =========================================================
// // Latihan 3 - Abstract Class
// // =========================================================

// Console.WriteLine(
//     "=== Latihan 3 - Abstract Class ==="
// );

// Manager manager = new Manager();

// manager.Name = "Samara";

// manager.DisplayName();
// manager.Work();

// Console.WriteLine();

// Developer dev = new Developer();

// dev.Name = "Tera";

// dev.DisplayName();
// dev.Work();

// Console.WriteLine();

// // =========================================================
// // Latihan 4 - Abstract + Interface
// // =========================================================

// Console.WriteLine(
//     "=== Latihan 4 - Abstract + Interface ==="
// );

// Car car = new Car();

// car.Brand = "Toyota";

// Console.WriteLine(
//     $"Brand: {car.Brand}"
// );

// car.Start();
// car.Move();

// Console.WriteLine();

// Motorcycle motor = new Motorcycle();

// motor.Brand = "Honda";

// Console.WriteLine(
//     $"Brand: {motor.Brand}"
// );

// motor.Start();
// motor.Move();

// Console.WriteLine();

// // =========================================================
// // Latihan 5 - Gabungan
// // =========================================================

// Console.WriteLine(
//     "=== Latihan 5 - Gabungan ==="
// );

// Manajer mj = new Manajer();

// mj.Name = "Samara";

// mj.EmployeeId = 1001;

// mj.Salary = 7500000;

// mj.DisplayInfo();

// mj.Work();

// mj.EmployeeInformation();

// Console.WriteLine(
//     $"Gaji bulanan: Rp.{mj.Salary}"
// );

// Console.WriteLine(
//     $"Gaji tahunan: Rp.{mj.CalculateAnnualSalary()}"
// );

// Console.WriteLine();

// // =========================================================
// // POLYMORPHISM - LATIHAN 1
// // Basic Polymorphism
// // =========================================================

// Console.WriteLine(
//     "=== Polymorphism 1 ==="
// );

// Animal animal1 = new Dogg();

// Animal animal2 = new Catt();

// animal1.MakeSound();

// animal2.MakeSound();

// Console.WriteLine();

// // =========================================================
// // POLYMORPHISM - LATIHAN 2
// // Polymorphism melalui Method
// // =========================================================

// Console.WriteLine(
//     "=== Polymorphism 2 ==="
// );

// AnimalHelper.PlaySound(new Catt());

// AnimalHelper.PlaySound(new Dogg());

// Console.WriteLine();

// // =========================================================
// // POLYMORPHISM - LATIHAN 3
// // Interface Polymorphism
// // =========================================================

// Console.WriteLine(
//     "=== Polymorphism 3 ==="
// );

// IMovable movable1 = new Carr();

// IMovable movable2 = new Motorcyclee();

// IMovable movable3 = new Bicycle();

// movable1.Move();

// movable2.Move();

// movable3.Move();

// Console.WriteLine();

// // =========================================================
// // POLYMORPHISM - LATIHAN 4
// // List Polymorphism
// // =========================================================

// Console.WriteLine(
//     "=== Polymorphism 4 ==="
// );

// List<Employei> employees = new List<Employei>();

// employees.Add(new Manager());
// employees.Add(new Developer());
// employees.Add(new Designer());

// foreach (Employei employee in employees)
// {
//     employee.Work();
// }

// Console.WriteLine();

// // =========================================================
// // POLYMORPHISM - LATIHAN 5
// // Overloading
// // =========================================================

// Console.WriteLine(
//     "=== Polymorphism 5 - Overloading ==="
// );

// Calculator calculator = new Calculator();

// Console.WriteLine(
//     $"Add(10, 20) = {calculator.Add(10, 20)}"
// );

// Console.WriteLine(
//     $"Add(10, 20, 30) = {calculator.Add(10, 20, 30)}"
// );

// Console.WriteLine(
//     $"Add(10.5, 20.5) = {calculator.Add(10.5, 20.5)}"
// );

// Console.WriteLine();

// // =========================================================
// // POLYMORPHISM - LATIHAN 5
// // Overriding
// // =========================================================

// Console.WriteLine(
//     "=== Polymorphism 5 - Overriding ==="
// );

// EmployeeNew employ1 = new Manazer();

// EmployeeNew employ2 = new Develover();

// employ1.Work();

// employ2.Work();

// // =========================================================
// // LATIHAN 1 - BASIC STRUCT
// // =========================================================

// Console.WriteLine("=== Latihan 1 - Basic Struct ===");

// ProductValue product1 = new ProductValue();

// ProductValue product2 = new ProductValue();

// product1.Name = "Oreo";

// product1.Price = 10000;

// product2 = product1;

// product2.Name = "Milo";

// Console.WriteLine($"Nama product 1 = {product1.Name}");

// Console.WriteLine($"Nama product 2 = {product2.Name}");

// Console.WriteLine();

// // =========================================================
// // LATIHAN 2 - CLASS REFERENCE TYPE
// // =========================================================

// Console.WriteLine("=== Latihan 2 - Class Reference Type ===");

// ProductReference prod1 = new ProductReference();

// ProductReference prod2 = new ProductReference();

// prod1.Name = "Dancow";

// prod1.Price = 12000;

// prod2 = prod1;

// prod2.Name = "Good Day";

// Console.WriteLine($"Nama product 1 = {prod1.Name}");

// Console.WriteLine($"Nama product 2 = {prod2.Name}");

// Console.WriteLine();

// // =========================================================
// // LATIHAN 3 - METHOD PARAMETER
// // =========================================================

// Console.WriteLine("=== Latihan 3 - Method Parameter ===");

// // -------------------------
// // int
// // -------------------------

// int number1 = 10;

// StructHelper.ChangeNumber(number1);

// Console.WriteLine($"number1 setelah method = {number1}");

// // -------------------------
// // struct
// // -------------------------

// ProductValue product3 = new ProductValue();

// product3.Name = "Oreo";

// StructHelper.ChangeStruct(product3);

// Console.WriteLine($"product3.Name setelah method = {product3.Name}");

// // -------------------------
// // class
// // -------------------------

// ProductReference product4 = new ProductReference();

// product4.Name = "Dancow";

// StructHelper.ChangeProduct(product4);

// Console.WriteLine($"product4.Name setelah method = {product4.Name}");

// Console.WriteLine();

// // =========================================================
// // LATIHAN 4 - REF
// // =========================================================

// Console.WriteLine("=== Latihan 4 - ref ===");

// int number2 = 10;

// StructHelper.ChangeNumber(ref number2);

// Console.WriteLine($"number2 setelah ref = {number2}");

// Console.WriteLine();

// // =========================================================
// // LATIHAN 5 - GABUNGAN
// // =========================================================

// Console.WriteLine("=== Latihan 5 - Gabungan ===");

// // -------------------------
// // Value Type
// // -------------------------

// StudentValue student1 = new StudentValue();

// student1.Name = "Tera";

// // -------------------------
// // Reference Type
// // -------------------------

// StudentReference student2 = new StudentReference();

// student2.Name = "Tera";

// // -------------------------
// // Jalankan method
// // -------------------------

// StructHelper.ChangeStudent(student1, student2);

// // -------------------------
// // Tampilkan hasil
// // -------------------------

// Console.WriteLine($"StudentValue.Name = {student1.Name}");

// Console.WriteLine($"StudentReference.Name = {student2.Name}");

// =========================================================
// LATIHAN Dynamic, Object & Variable
// =========================================================
// VarPractice.JalankanPraktik1();
// ObjectPractice.JalankanPraktik2();
// CheckType.JalankanPraktik3();
// DynamicPractice.JalankanPraktik4();
// MixPractice.JalankanPraktik5();

// =========================================================
// LATIHAN Lanjutan Dynamic, Object & Variable
// =========================================================
DataProduct.JalankanLatihan1();
TaxProduct.JalankanLatihan2();
CheckObject.JalankanLatihan3();
ChangeType.JalankanLatihan4();
MixType.JalankanLatihan5();