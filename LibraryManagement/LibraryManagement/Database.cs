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

            }
            return false;
        }
    }
}
