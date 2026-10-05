using System;

namespace BelajarCSharp
{
    // =========================================================
    // SOAL 1 - Student
    // =========================================================
    class Student
    {
        public string Name { get; set; }
        private int Age;

        public void SetAge(int age)
        {
            // Validasi, artinya tidak mengizinkan apa bila age kurang dari 0
            if (age >= 0)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("Umur tidak valid");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nama: {Name}");
            Console.WriteLine($"Umur: {Age}");
            Console.WriteLine();
        }
    }

    // =========================================================
    // SOAL 2 - BankAccount
    // =========================================================
    class BankAccount
    {
        private int accountNumber; // Karena accountNumber biasanya merupakan identitas rekening dan tidak seharusnya sembarang diubah // Field untuk menyimpan account number dan membuat variabel
        private decimal balance;

        // karena private kita buat Constructor dengan account number sebagai parameter agar dapat di isi lewat constructor
        public BankAccount(int accountNumber)
        {
            this.accountNumber = accountNumber; // sehingga dapat disimpan kedalam object
            balance = 0;
        }

        // Hanya bisa dibaca dari luar
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Jumlah Deposit sebesar Rp.{amount}");
                balance += amount;
            }
            else
            {
                Console.WriteLine("Jumlah deposit tidak valid.");
                return;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Jumlah penarikan tidak valid");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Saldo tidak cukup.");
                return;
            }

            Console.WriteLine($"Jumlah Penarikan sebesar Rp.{amount}");
            balance -= amount;
        }

        public decimal GetBalance()
        {
            Console.WriteLine($"Saldo saat ini sebesar Rp.{balance}");
            return balance;
        }
    }

    // =========================================================
    // SOAL 3 - Employee
    // =========================================================
    class Employee
    {
        // Soalnya meminta: Salary bisa dibaca dari luar tetapi tidak boleh diubah langsung dari luar.
        public string Name { get; set; }
        public decimal Salary { get; private set; } // public decimal Salary -> bisa dibaca dari luar, private set -> tidak bisa diubah dari luar

        public void RaiseSalary(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Angka tidak valid");
                return;
            }

            Salary += amount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nama: {Name}");
            Console.WriteLine($"Gaji: {Salary}");
            Console.WriteLine();
        }
    }

    // =========================================================
    // SOAL 4 - Inheritance + Property
    // =========================================================
    class Person
    {
        public string Name { get; set; } // ini merupakan Property, BUKAN Field

        private int Age { get; set; }

        protected decimal Salary { get; set; }

        internal string Address { get; set; }

        protected internal string Email { get; set; }
    }

    class Employeee : Person
    {
        public void TestAccess() // cara mengisi method pengujuan TestAccess
        {
            // PUBLIC
            Console.WriteLine($"Nama: {Name}");

            // PRIVATE
            // Console.WriteLine($"Umur: {age}");   // kita comment karena akan error. property bersifat private, hanya class person yang bisa mengakses

            // PROTECTED
            Console.WriteLine($"Gaji: {Salary}");

            // INTERNAL
            // bisa di akses karena Employee dan Person
            // berada dalam assembly yang sama
            Console.WriteLine($"Alamat: {Address}");

            // PROTECTED INTERNAL
            Console.WriteLine($"Email: {Email}");
        }
    }

    // =========================================================
    // SOAL 5 - Product
    // =========================================================
    class Product
    {
        public string Name { get; set; }
        private decimal price; // ini namanya backing field
        public decimal Price
        {
            get { return price; }
            private set // Artinya dari luar class
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        private int stock;

        public Product(string name, decimal price)
        {
            Name = name;

            if (price > 0)
            {
                this.price = price;
            }
            else
            {
                this.price = 0;
                Console.WriteLine("Harga tidak valid");
            }

            stock = 0;
        }

        public void AddStock(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Jumlah stock tidak valid.");
                return;
            }
            Console.WriteLine($"Tambah stok sebanyak {quantity}");
            stock += quantity;
        }

        public void Sell(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Jumlah penjualan tidak valid");
                return;
            }

            if (quantity > stock)
            {
                Console.WriteLine("Stock tidak cukup");
                return;
            }

            Console.WriteLine($"terjual sebanyak{quantity}");
            stock -= quantity;
        }

        public int StockBalance()
        {
            Console.WriteLine($"Stock saat ini {stock}");
            return stock;
        }
    }

    // =========================================================
    // Latihan A - Person
    // =========================================================
    class Personn
    {
        public string Name { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            private set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }

    // =========================================================
    // Latihan B - Productt
    // =========================================================
    class Productt
    {
        public string Name { get; set; }
        public decimal Price { get; private set; }

        public void ChangePrice(decimal newPrice)
        {
            if (newPrice > 0)
            {
                Price = newPrice;
            }
            else
            {
                Console.WriteLine("Harga baru tidak valid");
                return;
            }
        }
    }

    // =========================================================
    // Latihan C - BankAccountt
    // =========================================================
    class BankAccountt
    {
        private int accountNumber;
        private decimal balance;

        public BankAccountt(int accountNumber)
        {
            this.accountNumber = accountNumber;
            balance = 0;
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public decimal Balance
        {
            get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Deposit sebesar Rp.{amount}");
                balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit tidak valid!");
                return;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Jumlah penarikan tidak valid");
                return;
            }

            if (amount > balance)
            {
                Console.WriteLine("Saldo tidak cukup.");
                return;
            }
            Console.WriteLine($"Penarikan Dana sebesar Rp.{amount}");
            balance -= amount;
        }

        public decimal GetBalance()
        {
            Console.WriteLine($"Sisa saldo sekarang Rp.{balance}");
            return balance;
        }
    }

    // =========================================================
    // Latihan D - Employes
    // =========================================================
    class Employes
    {
        public string Name { get; set; }

        public decimal Salary { get; private set; }

        public void RaiseSalary(decimal amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Jumlah Kenaikan Gaji sebesar Rp.{amount}");
                Salary += amount;
            }
            else
            {
                Console.WriteLine("Pengajuan kenaikan gaji tidak disetujui");
                return;
            }
        }
    }

    // =========================================================
    // Latihan E - Gabungan Semuanya
    // =========================================================
    class Produck
    {
        public string Name { get; set; }
        private decimal price;
        public decimal Price
        {
            get { return price; }
            private set // Artinya dari luar class
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
        public int Stockk { get; private set; }

        public Produck(string name, decimal price)
        {
            Name = name;

            if (price > 0)
            {
                this.price = price;
            }
            else
            {
                this.price = 0;
                Console.WriteLine("Harga tidak valid");
            }

            Stockk = 0;
        }

        public void AddStock(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Jumlah stock tidak valid.");
                return;
            }
            Console.WriteLine($"Tambah stok sebanyak {quantity}");
            Stockk += quantity;
        }

        public void Sell(int quantity)
        {
            if (quantity <= 0)
            {
                Console.WriteLine("Jumlah penjualan tidak valid");
                return;
            }

            if (quantity > Stockk)
            {
                Console.WriteLine("Stock tidak cukup");
                return;
            }

            Console.WriteLine($"terjual sebanyak{quantity}");
            Stockk -= quantity;
        }

        public int StockBalance()
        {
            Console.WriteLine($"Stock saat ini {Stockk}");
            return Stockk;
        }
    }
}
