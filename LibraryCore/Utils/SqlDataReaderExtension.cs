using System;
using System.Data.SqlClient;

namespace LibraryCore.Utils
{
    public static class SqlDataReaderExtension
    {
        public static int GetInt32(this SqlDataReader reader, string columnName)
        {
            //reader.GetInt32(0); // sütun sırasından asılı olmaq
            //Convert.ToInt32(reader["Id"]); // çox uzun koddu
            return Convert.ToInt32(reader[columnName]);
        }

        public static string GetString(this SqlDataReader reader, string columnName)
        {
            return Convert.ToString(reader[columnName]);
        }

        public static bool GetBoolean(this SqlDataReader reader, string columnName)
        {
            return Convert.ToBoolean(reader[columnName]);
        }

        public static DateTime GetDateTime(this SqlDataReader reader, string columnName)
        {
            return Convert.ToDateTime(reader[columnName]);
        }



    }
}
