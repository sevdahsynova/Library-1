using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utils
{
    public class Logger
    {
        public static void LogError(string message)
        {
            // asinxron loqlamaq lazımdır

            Task.Run(() =>
            {
                try
                {
                    using (var writer = File.AppendText(LibraryCore.Utils.Constants.LOGFILEPATH))
                    {
                        writer.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture));
                        writer.WriteLine(message);
                        writer.WriteLine();
                        writer.WriteLine();
                    }
                }
                catch
                {

                }
            });
        }

        public static void LogInformation(string message)
        {
            Task.Run(() =>
            {
                try
                {
                    using (var writer = File.AppendText(LibraryCore.Utils.Constants.LOGFILEPATH))
                    {
                        writer.WriteLine(DateTime.Now.ToString(CultureInfo.InvariantCulture));
                        writer.WriteLine(message);
                        writer.WriteLine();
                        writer.WriteLine();
                    }
                }
                catch
                {

                }
            });
        }
    }
}
