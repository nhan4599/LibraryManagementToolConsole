using System.Data.SqlClient;

namespace LibraryManagement
{
    class Database
    {
        private const string connectionString = "Data Source=DESKTOP-ARHTHJK;Initial Catalog=QLNhanVien;User ID=sa;Password=nhan4599";
        public static bool GetUserIsDuplicated(string user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string cmd = string.Format("SELECT username FROM userList WHERE username = '{0}'", user);
                SqlCommand command = new SqlCommand(cmd, conn);
                if (command.ExecuteScalar() != null)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
        }
    }
}
