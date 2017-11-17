using Logger.CL.Interfaces;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Logger.CL
{
    public sealed class FileLogger : IFileLogger
    {
        public async Task Log(string className,
            string methodName,
            Exception ex)
        {
            try
            {
                //Path points to api root
                var logDir = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory.ToString(),
                                          "Logs");

                //Only creates if dir does not exist
                Directory.CreateDirectory(logDir);

                // WriteAllText creates a file, writes the specified string to the file,
                // and then closes the file. You do NOT need to call Flush() or Close().
                File.WriteAllText(logDir + "\\" + DateTime.Now.Ticks.ToString() + ".txt",
                    LogBuilder.Build(className, methodName, ex));

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
