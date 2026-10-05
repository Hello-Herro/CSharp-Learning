using System;

namespace BelajarCSharp
{
    // =========================================================
    // Latihan 1 - Day
    // =========================================================
    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    // =========================================================
    // Latihan 2 - Order Status
    // =========================================================
    enum OrderStatus
    {
        Pending,
        Paid,
        Shipped,
        Completed,
        Cancelled,
    }

    class Order_Status
    {
        public int Id { get; set; }
        public OrderStatus Status { get; set; }

        public void DisplayStatus()
        {
            switch (Status)
            {
                case OrderStatus.Pending:
                    Console.WriteLine("Pesanan Belum dibayar");
                    break;

                case OrderStatus.Paid:
                    Console.WriteLine("Pesanan Sudah dibayar");
                    break;

                case OrderStatus.Shipped:
                    Console.WriteLine("Pesanan sedang dikirim");
                    break;

                case OrderStatus.Completed:
                    Console.WriteLine("Pesanan sudah selesai");
                    break;

                case OrderStatus.Cancelled:
                    Console.WriteLine("Pesanan dibatalkan!");
                    break;

                default:
                    Console.WriteLine("Status pesanan tidak dikenal");
                    break;
            }
        }
    }

    // =========================================================
    // Latihan 3 - User Account
    // =========================================================
    enum UserAccount // enum untuk menentukan Role
    {
        Admin,
        Moderator,
        Editor,
        User,
    }

    class User_Account
    {
        public string Username { get; set; }
        public UserAccount Role { get; set; }
    }

    // =========================================================
    // Latihan 4 - Payment Method
    // =========================================================
    enum PaymentMethod
    {
        Cash,
        BankTransfer,
        CreditCard,
        EWallet,
    }

    class Payment
    {
        public double Amount { get; set; }
        public PaymentMethod Method { get; set; }

        public void ProcessPayment()
        {
            Console.WriteLine($"Pembayaran menggunakan {Method}");
            Console.WriteLine($"Jumlah : Rp.{Amount}");
            Console.WriteLine();
        }
    }

    // =========================================================
    // Latihan 5 - User Role
    // =========================================================
    enum UserRole
    {
        Admin,
        Manager,
        Staff,
        Guest,
    }

    class Employe
    {
        public string Name { get; set; }
        public UserRole Role { get; private set; }

        public void ChangeRole(UserRole newRole)
        {
            Role = newRole;
        }

        public void DisplayAccess() // tidak perlu di beri parameter karena object Employee sudah punya public UserRole Role { get; private set; }
        {
            Console.WriteLine($"Nama: {Name}");
            Console.WriteLine($"Role: {Role}");

            switch (Role)
            {
                case UserRole.Admin:
                    Console.WriteLine("Full access");
                    break;

                case UserRole.Manager:
                    Console.WriteLine("Management access");
                    break;

                case UserRole.Staff:
                    Console.WriteLine("Staff access");
                    break;

                case UserRole.Guest:
                    Console.WriteLine("Limited access");
                    break;
                default:
                    Console.WriteLine("Access tidak diketahui");
                    break;
            }
            Console.WriteLine();
        }
    }
}
