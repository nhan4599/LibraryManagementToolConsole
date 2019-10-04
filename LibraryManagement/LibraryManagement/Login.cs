using System;

namespace LibraryManagement
{
    class LoginSupports
    {
        public static void RequestLogin()
        {
            Console.Write("Username : ");
            string username = Console.ReadLine();
            Console.Write("Password : ");
            HideInputCharacter();
            string password = Console.ReadLine();
            ResetInputCharacter();
            if (TryToLogin(username, password))
            {
                Console.WriteLine("Login complete successfully");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                Console.Clear();
            }else
            {
                Console.WriteLine("Login failed");
                Console.WriteLine("Please re-input info to login");
                RequestLogin();
            }
        }

        private static bool TryToLogin(string username, string password)
        {
            return username == "sa" && password == "123456Az";
        }

        public static void HideInputCharacter()
        {
            Console.ForegroundColor = Console.BackgroundColor;
        }

        public static void ResetInputCharacter()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
