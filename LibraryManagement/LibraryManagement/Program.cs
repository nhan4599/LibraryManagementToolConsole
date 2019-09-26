using System;
using System.Text;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Welcome you to Library Management Tool");
            Console.WriteLine("First you need to login");
            LibraryManagement.LoginSupports.RequestLogin();
            ShowMenu();
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Input infomation");
            Console.WriteLine("2. Del book");
            Console.WriteLine("3. Find book");
            Console.WriteLine("4. Rent book");
            Console.WriteLine("5. Export Report");
            Console.WriteLine("6. Exit");
        }
    }
}
