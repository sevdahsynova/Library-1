using LibraryCore.DataAccess;
using LibraryCore.Domain.Abstract;
using LibraryCore.Enums;
using System;
using System.Data.SqlClient;

namespace LibraryCore.Factories
{
    public static class UnitOfWorkFactory
    {
        public static IUnitOfWork Create(string connString, SqlServerType serverType)
        {
            switch(serverType)
            {
                case SqlServerType.MsSql:
                    {
                        return new SqlUnitOfWork(connString);
                    }
                case SqlServerType.MySql:
                case SqlServerType.OracleSql:
                case SqlServerType.PostgreSql:
                default:
                    {
                        throw new NotSupportedException($"{serverType} not supported now. Please contact your developer team");
                    }
            }

        }

        public static string CreateConnString(string serverName, string dbName, string userId, string password, bool isWindowsAuthentication)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = serverName;
            builder.InitialCatalog = dbName;
            builder.IntegratedSecurity = isWindowsAuthentication;
            if(!isWindowsAuthentication) // it means SqlServer Authentication
            {
                builder.UserID = userId;
                builder.Password = password;
            }

            return builder.ConnectionString;
        }

    }
}
