using LibraryCore.Enums;
using System;

namespace LibraryCore.Configurations
{
    public class ConfigObject 
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public bool IsWindowsAuthentication { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public SqlServerType SqlServerType { get; set; }
    }
}
