using Library.Utils;
using Library.Views.Windows;
using System.IO;
using System.Windows;
using System.Windows.Threading;
using Constants = LibraryCore.Utils.Constants;

namespace Library
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            Dispatcher.UnhandledException += DispatcherUnhandledException;
        }

        private void DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // Start ==>  debug
            // Ctrl + F5  ==> without debug

            if (!Directory.Exists(Constants.LOGFILEFOLDER))
            {
                Directory.CreateDirectory(Constants.LOGFILEFOLDER);
            }

            Logger.LogError(e.Exception.ToString());
         
            UnknownErrorWindow error = new UnknownErrorWindow(SystemParameters.WorkArea.Width, SystemParameters.WorkArea.Height, Constants.ErrorMessage);
            error.ShowDialog();

            e.Handled = true;
        }

    }
}
