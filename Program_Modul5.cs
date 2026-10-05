using System;
using System.Globalization;
using BelajarCSharp;

// Memanggil kode

// Modul 5_Basic_OOP
// PEMANGGILAN - Latihan Obejct & Class
// // =========================================================
// // SOAL 1
// // =========================================================
// Laptop laptop1 = new Laptop(); // ini disebut Object, Object adalah hasil dari class. Sekarang laptop1 adalah object dari class Laptop.

// laptop1.Merk = "ASUS";
// laptop1.RAM = "16 GB";

// laptop1.Tampilkaninfo();

// // PEMANGGILAN
// // =========================================================
// // SOAL 2
// // =========================================================
// Kamera kamera1 = new Kamera(); // Object
// Kamera kamera2 = new Kamera(); // Object

// kamera1.Nama = "Canon EOS M50 II";
// kamera1.Harga = 6500000;

// kamera2.Nama = "Sony A6400";
// kamera2.Harga = 7500000;

// kamera1.CetakInfo();
// kamera2.CetakInfo();

// // PEMANGGILAN
// // =========================================================
// // SOAL 3
// // =========================================================
// Fotografer fg1 = new Fotografer("Tera", "Graduation Foto");

// fg1.Perkenalan();

// // PEMANGGULAN
// // =========================================================
// // SOAL 4
// // =========================================================
// RekeningBank rekening = new RekeningBank();

// rekening.NamaPemilik = "Tera";
// rekening.Saldo = 100000;

// rekening.LihatSaldo();

// rekening.Setor(50000);
// rekening.LihatSaldo();

// rekening.Tarik(25000);
// rekening.LihatSaldo();

// // PEMANGGILAN
// // =========================================================
// // SOAL 5
// // =========================================================
// Mahasiswa mahasiswa1 = new Mahasiswa(); // Object
// Mahasiswa mahasiswa2 = new Mahasiswa(); // Object

// mahasiswa1.Nama = "Tera";
// mahasiswa1.NIM = 2021001;
// mahasiswa1.Jurusan = "Teknik Informatika";
// mahasiswa1.Umur = 17;

// mahasiswa2.Nama = "Samara";
// mahasiswa2.NIM = 2021002;
// mahasiswa2.Jurusan = "Kesehatan Masyarakat";
// mahasiswa2.Umur = 17;

// Console.WriteLine("=== Mahasiswa 1 ===");
// mahasiswa1.TampilkanInfo();
// Console.WriteLine("=== Mahasiswa 2 ===");
// mahasiswa2.TampilkanInfo();

//  Class → PascalCase
//  Object/Variable → camelCase

// PEMANGGILAN - Latihan Assembly and Namespace
// // =========================================================
// // SOAL 1
// // =========================================================
// Laptopp laptop1 = new Laptopp();

// laptop1.Merk = "ASUS";
// laptop1.RAM = "16GB";
// laptop1.Harga = 12000000;

// Produk produk = new Produk();

// Console.WriteLine("Latihan 1\n");
// laptop1.TampilkanInfo();

// produk.NamaProduk = "Coffe Latte";
// produk.Harga = -1000;

// // =========================================================
// // SOAL 2
// // =========================================================
// Console.WriteLine("Latihan 2\n");
// Console.WriteLine("=== MENU ===");
// produk.TampilkanInfo();

// Karyawan karyawan1 = new Karyawan();
// Karyawan karyawan2 = new Karyawan();
// Karyawan karyawan3 = new Karyawan();

// karyawan1.Nama = "Andi";
// karyawan1.Jabatan = "IT Support";
// karyawan1.Gaji = 7500000;

// karyawan2.Nama = "Budi";
// karyawan2.Jabatan = "Programmer";
// karyawan2.Gaji = 10000000;

// karyawan3.Nama = "Citra";
// karyawan3.Jabatan = "UI/UX Designer";
// karyawan3.Gaji = 8500000;

// // =========================================================
// // SOAL 3
// // =========================================================
// Console.WriteLine("Latihan 3\n");
// Console.WriteLine("=== Karyawan 1 ===");
// karyawan1.TampilkanInfo();
// Console.WriteLine("=== Karyawan 2 ===");
// karyawan2.TampilkanInfo();
// Console.WriteLine("=== Karyawan 3 ===");
// karyawan3.TampilkanInfo();

//////////////////////////////////////////////////
// Mobil mobil1 = new Mobil("Toyota", 2022);
// // Console.WriteLine("=== Mobil 1 ===\n");
// mobil1.TampilkanInfo();

// Mobil mobil2 = new Mobil("Honda", 2023);
// // Console.WriteLine("=== Mobil 2 ===\n");
// mobil2.TampilkanInfo();

// PEMANGGILAN - Latihan Constant and Read Only
// Mobill mobil1 = new Mobill("MH12345", "Toyota");

// mobil1.NomorRangka = "ABC999";

// // =========================================================
// // SOAL 1
// // =========================================================
// Console.WriteLine("=== Latihan 1 ===\n");
// mobil1.TampilkanInfo();

// // =========================================================
// // SOAL 2
// // =========================================================
// Console.WriteLine("=== Latihan 2 ===\n");
// Mobill.RodaMobil();

// PEMANGGILAN - Latihan Dynamic & Static
// Counter c1 = new Counter();
// Counter c2 = new Counter();
// Counter c3 = new Counter();

// Console.WriteLine("=== Latihan Dynamic & Static ===");
// Console.WriteLine(Counter.Jumlah);

// // =========================================================
// // SOAL 1
// // =========================================================
// Hewan hewan1 = new Hewan();
// Hewan hewan2 = new Hewan();

// hewan1.Nama = "Kucing";
// hewan1.Jenis = "Mamalia";

// hewan2.Nama = "Burung";
// hewan2.Jenis = "Unggas";

// hewan1.TampilkanInfo();
// hewan2.TampilkanInfo();

// // =========================================================
// // SOAL 2
// // =========================================================
// Buku buku1 = new Buku("Laskar Pelangi", "Andrea Hirata");

// buku1.TampilkanInfo();
// // Console.WriteLine(Buku.TampilkanInfo);

// // =========================================================
// // SOAL 3
// // =========================================================
// Motor motor1 = new Motor("Honda", 2021);

// motor1.TampilkanInfo();

// // =========================================================
// // SOAL 4
// // =========================================================
// Mahasiswaa mahasiswa1 = new Mahasiswaa();

// mahasiswa1.Nama = "Tera";
// mahasiswa1.Jurusan = "Teknik Informatika";

// mahasiswa1.TampilkanInfo();

// // =========================================================
// // SOAL 5
// // =========================================================
// Laptoop laptop = new Laptoop("SN001");

// laptop.SerialNumber = "ABC123"; // Read Only hanya bisa di isi di parameter setelah object dibuat karena nilai sudah dikunci, maka ini tidak perlu

// laptop.TampilkanInfo();

// // =========================================================
// // SOAL 6
// // =========================================================
// TampilkanPI();
// Matematika mtk = new Matematika();
// mtk.TampilkanPI();;

// // =========================================================
// // SOAL 7
// // =========================================================
// Pengunjung pengunjung1 = new Pengunjung();
// Pengunjung pengunjung2 = new Pengunjung();
// Pengunjung pengunjung3 = new Pengunjung();
// Pengunjung pengunjung4 = new Pengunjung();
// Pengunjung pengunjung5 = new Pengunjung();

// Console.WriteLine(Pengunjung.JumlahPengunjung);

// // =========================================================
// // SOAL 8
// // =========================================================
// Console.WriteLine(Kalkulator.Tambah(5,3));

// // =========================================================
// // SOAL 10
// // =========================================================
// Pegawai pegawai1 = new Pegawai("Andi", 5000000);
// Pegawai pegawai2 = new Pegawai("Budi", 7000000);
// Pegawai pegawai3 = new Pegawai("Citra", 8000000);

// pegawai1.TampilkanInfo();
// pegawai2.TampilkanInfo();
// pegawai3.TampilkanInfo();
// Console.WriteLine($"Total Pegawai: {Pegawai.JumlahPegawai}");
// Console.WriteLine();

// // PEMANGGILAN - Latihan Inheritance
// // =========================================================
// // SOAL 1 
// // =========================================================
// Console.WriteLine("Latihan 1 - Dasar");
// Mobilll mobil1 = new Mobilll();

// mobil1.Merk = "Toyota";
// mobil1.Tahun = 2023;

// mobil1.TampilkanInfo();

// // =========================================================
// // SOAL 2
// // =========================================================
// Console.WriteLine("Latihan 2");
// Programmer coding1 = new Programmer();

// coding1.Nama = "Tera";
// coding1.Gaji = 7000000;

// coding1.TampilkanInfo();

// PEMANGGILAN - Latihan Encapsulation
// // =========================================================
// // SOAL 1 - Student
// // =========================================================
// Console.WriteLine("=== Latihan Soal Dasar Encapsulation ===");

// Student student = new Student();

// student.Name = "Tera";
// student.SetAge(21);

// student.DisplayInfo();

// // =========================================================
// // SOAL 2 - BankAccount
// // =========================================================
// Console.WriteLine("=== Latihan Soal 2 ===");

// BankAccount account = new BankAccount(123456);

// Console.WriteLine($"Nomor Rekening: {account.AccountNumber}");

// account.Deposit(500000);
// account.Withdraw(150000);
// account.GetBalance();

// Console.WriteLine();

// // =========================================================
// // SOAL 3 - Employee
// // =========================================================
// Console.WriteLine("=== Latihan Soal 3 ==="); // Access modifier bergantung pada siapa yang sedang mencoba mengakses member tersebut.

// Employee emp = new Employee();

// emp.Name = "Budi";
// emp.RaiseSalary(1000000);

// Console.WriteLine($"Nama: {emp.Name}");
// Console.WriteLine($"Gaji: {emp.Salary}");

// Console.WriteLine();

// // =========================================================
// // SOAL 4 - Person & Employeee
// // =========================================================
// Console.WriteLine("=== Latihan Soal 4 ===");

// Employeee emp1 = new Employeee();

// emp1.Name = "Tera";

// // PRIVATE
// // emp1.Age = 25;

// // PROTECTED
// // emp1.Salary = 8000000;

// // INTERNAL
// emp1.Address = "Jakarta";

// // PROTECTED INTERNAL
// emp1.Email = "tera@gmail.com";

// emp1.TestAccess();
// Console.WriteLine();

// // =========================================================
// // SOAL 5 - Product
// // =========================================================
// Console.WriteLine("=== Latihan Soal 5 ===");

// Product product = new Product("Keyboard", 500000);

// Console.WriteLine($"Nama Produk: {product.Name}");
// Console.WriteLine($"Harga: Rp.{product.Price}");

// product.AddStock(10);
// product.Sell(3);
// product.Sell(2);

// product.StockBalance();

// // PANGGILAN LATIHAN PROPERTY
// // Latihan A
// Personn prs = new Personn();

// prs.Name = "Tera";
// prs.SetAge(21);

// // Latihan B
// Productt prd = new Productt();
// prd.Name = "Mouse";
// prd.ChangePrice(300000);

// Console.WriteLine($"Nama: {prd.Name}");
// Console.WriteLine($"Harga: Rp.{prd.Price}");

// // Latihan C
// BankAccountt ba = new BankAccountt(67890);

// ba.Deposit(1000000);
// ba.Withdraw(800000);
// ba.GetBalance();

// // Latihan D
// Employes empp = new Employes();

// empp.RaiseSalary(20000000);

// // Latihan E
// Produck prdd = new Produck("Monitor", 3000000);

// Console.WriteLine($"Nama Produk: {prdd.Name}");
// Console.WriteLine($"Harga: Rp.{prdd.Price}");

// prdd.AddStock(15);
// prdd.Sell(10);
// prdd.Sell(5);

// prdd.StockBalance();

// // PEMANGGILAN - Latihan Enumeration
// // =========================================================
// // Latihan 1 - Day
// // =========================================================
// Console.WriteLine("=== Latihan 1 - Day ===");

// Day today = Day.Monday;

// Console.WriteLine($"Hari ini : {today}");

// Console.WriteLine();

// // =========================================================
// // Latihan 2 - Order Status
// // =========================================================
// Console.WriteLine("=== Latihan 2 - Order Status ===");

// Order_Status order = new Order_Status();

// order.Id = 1001;

// order.Status = OrderStatus.Pending;

// Console.WriteLine($"Order ID : {order.Id}");
// Console.WriteLine($"Status   : {order.Status}");

// order.DisplayStatus();

// Console.WriteLine();

// // =========================================================
// // Latihan 3 - User Account
// // =========================================================
// Console.WriteLine("=== Latihan 3 - User Account ===");

// User_Account user = new User_Account();

// user.Username = "Tera";
// user.Role = UserAccount.Admin;

// Console.WriteLine($"Username : {user.Username}");
// Console.WriteLine($"Role : {user.Role}");

// Console.WriteLine();

// // =========================================================
// // Latihan 4 - Payment Method
// // =========================================================
// Console.WriteLine("=== Latihan 4 - Payment Method ===");

// Payment payment = new Payment();

// payment.Amount = 500000;
// payment.Method = PaymentMethod.EWallet;

// payment.ProcessPayment();

// // =========================================================
// // Latihan 5 - User Role
// // =========================================================
// Console.WriteLine("=== Latihan 5 - User Role ===");

// Employe emplo = new Employe();

// emplo.Name = "Tera";

// emplo.ChangeRole(UserRole.Manager);

// emplo.DisplayAccess();
