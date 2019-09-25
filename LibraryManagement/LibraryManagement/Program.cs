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
        }
    }
}
