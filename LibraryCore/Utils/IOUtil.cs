using System;
using System.IO;

namespace LibraryCore.Utils
{
    public static class IOUtil
    {
        public static bool ConfigurationFileExist(string fileName)
        {
            return File.Exists(fileName);
        }

        public static bool WriteFile(string fileName, string content)
        {
            try
            {
                File.WriteAllText(fileName, content);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string ReadFile(string fileName)
        {
            try
            {
                return File.ReadAllText(fileName);
            }
            catch
            {
                return null;
            }
        }


    }
}
