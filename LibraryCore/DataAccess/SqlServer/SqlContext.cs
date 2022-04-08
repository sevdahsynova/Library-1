using System;

namespace LibraryCore.DataAccess
{
    public class SqlContext
    {
        public string ConnString { get; }
        public SqlContext(string connString)
        {
            ConnString = connString;
        }
    }
}
