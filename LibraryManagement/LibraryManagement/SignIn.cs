using System;
using System.Text.RegularExpressions;

namespace LibraryManagement
{
    class SignIn
    {
        public static void SignUp()
        {
            Console.WriteLine("Username : ");
            string user = Console.ReadLine();
            while (!IsValidUsername(user))
            {
                Console.Write("ReEnter - Username : ");
                user = Console.ReadLine();
            }

            Console.Write("Password : ");
            LoginSupports.HideInputCharacter();
            string pass = Console.ReadLine();
            LoginSupports.ResetInputCharacter();
            while (!IsValidPassword(pass))
            {
                Console.Write("ReEnter - Password : ");
                LoginSupports.HideInputCharacter();
                pass = Console.ReadLine();
                LoginSupports.ResetInputCharacter();
            }

            Console.Write("Name : ");
            string name = Console.ReadLine();

            Console.Write("Birthday : ");
            string birthday = Console.ReadLine();
            while (!IsBirthday(birthday))
            {
                Console.Write("ReEnter - Birthday : ");
                birthday = Console.ReadLine();
            }

            Console.Write("Email : ");
            string mail = Console.ReadLine();
            while (!IsEmail(mail))
            {
                Console.Write("Re - Email : ");
                mail = Console.ReadLine();
            }
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

        private static bool IsBirthday(string birthday)
        {
            try
            {
                DateTime t = DateTime.ParseExact(birthday, "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                Console.WriteLine(t);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool IsEmail(string mail)
        {
            Regex reg = new Regex("\\w+[\\w\\.]*@(\\w+\\.)+\\w+");
            return reg.IsMatch(mail);
        }
    }
}
