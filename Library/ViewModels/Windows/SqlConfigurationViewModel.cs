using Library.Commands;
using Library.Commands.ConfigurationCommands;
using LibraryCore.Configurations;
using LibraryCore.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace Library.ViewModels
{
    public class SqlConfigurationViewModel : WindowViewModel
    {

        public SaveSqlConfigurationCommand Save => new SaveSqlConfigurationCommand(this);
        public CancelConfigurationCommand Cancel => new CancelConfigurationCommand(this);


        private List<SqlServerType> serverTypes;
        public List<SqlServerType> ServerTypes
        {
            get
            {
                if (serverTypes == null)
                {
                    serverTypes = new List<SqlServerType>()
                    {
                        SqlServerType.MsSql,
                         SqlServerType.MySql,
                          SqlServerType.OracleSql,
                           SqlServerType.PostgreSql
                    };
                }
                return serverTypes;
            }
        }

        private ConfigObject configObject = new ConfigObject();
        public ConfigObject ConfigObject
        {
            get => configObject;
            set
            {
                configObject = value;
                OnPropertyChanged(nameof(ConfigObject));
            }
        }


    }
}
