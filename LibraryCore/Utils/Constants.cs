using System;
using System.IO;

namespace LibraryCore.Utils
{
    public static class Constants
    {
        private static string applicationFilesDirectory = "C:/Library";
        public static string ApplicationFilesDirectory
        {
            get
            {
                if(!Directory.Exists(applicationFilesDirectory))
                {
                    Directory.CreateDirectory(applicationFilesDirectory);
                }

                return applicationFilesDirectory;
            }
        }

        public static string ConfigurationFilePath => $"{ApplicationFilesDirectory}/Configs.json";
        public static string ErrorMessage = "Bilinməyən bir xəta baş verdi";

        public static string LOGFILEFOLDER = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Library\";

        public static string LOGFILEPATH = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Library\log.txt";
    }
}