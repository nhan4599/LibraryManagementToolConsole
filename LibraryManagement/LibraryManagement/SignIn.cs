using System;
using System.Text.RegularExpressions;

namespace LibraryManagement
{
    class SignIn
    {
        public static void SignUp()
        {
            Console.Write("Username : ");
            string user = Console.ReadLine();

            Console.Write("Password : ");
            string pass = Console.ReadLine();

            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Birthday : ");
            string birthday = Console.ReadLine();

            Console.Write("Email : ");
            string mail = Console.ReadLine();

            
        }

        public static bool IsValidPassword(string password)
        {
            Regex reg = new Regex("\\w{8}");
            return reg.IsMatch(password);
        }

        private static bool IsValidUsername(string username)
        {
            Regex reg = new Regex("\\w{6}");
            return reg.IsMatch(username);
        }

        public static bool IsBirthday(string birthday)
        {
            try
            {
                DateTime.Parse(birthday);
            }catch
            {
                return false;
            }
            return true;
        }
    }
}
