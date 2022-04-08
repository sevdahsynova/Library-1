using Library.ViewModels;
using LibraryCore.Configurations;
using LibraryCore.Factories;
using LibraryCore.Utils;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Library.Views
{
    /// <summary>
    /// Interaction logic for WindowStart.xaml
    /// </summary>
    public partial class WindowStart : Window
    {
        // called before window loading
        public WindowStart()
        {
            InitializeComponent();
            // shouldn't write any heavy (even simple) logic in constructor
        }

        // called after window loading
        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            CheckServer(); // automatically created new thread for this method
        }

        private async void CheckServer()
        {
            bool exists = IOUtil.ConfigurationFileExist(Constants.ConfigurationFilePath);
            if(exists)
            {
                string content = IOUtil.ReadFile(Constants.ConfigurationFilePath);
                ConfigObject config = JsonConvert.DeserializeObject<ConfigObject>(content);
                if(!config.IsWindowsAuthentication)
                {
                    config.Password = SecurityUtil.Decrypt(config.Password);
                }
                string connString = UnitOfWorkFactory.CreateConnString(config.ServerName, config.DatabaseName, config.UserId, config.Password, config.IsWindowsAuthentication);
                Kernel.Db = UnitOfWorkFactory.Create(connString, config.SqlServerType);
                bool isOnline = Kernel.Db.CheckServer();

                if (isOnline)
                {
                    // go to login page
                    //await Task.Delay(2500);

                    LoginViewModel viewModel = new LoginViewModel();
                    LoginPage loginPage = new LoginPage();
                    viewModel.Window = loginPage;
                    loginPage.DataContext = viewModel;
                    this.Close();
                    loginPage.Show();
                }
                else
                {
                    OpenConfigurationPage(); 
                }
            }
            else
            {
                OpenConfigurationPage();
            }
        }


        private void OpenConfigurationPage()
        {
            SqlConfigurationViewModel viewModel = new SqlConfigurationViewModel();
            SqlConfiguration configWindow = new SqlConfiguration();
            viewModel.Window = configWindow;
            configWindow.DataContext = viewModel;
            this.Close();
            configWindow.Show();
        }


    }
}
