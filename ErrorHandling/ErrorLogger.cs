using System;
using System.IO;
using System.Configuration;

namespace ErrorHandling
{
    public static class ErrorLogger
    {
        public static void WriteLogToFile(string errorMessage)
        {
            string filepath = ConfigurationManager.AppSettings["ErrorlogPath"];
            StreamWriter errorLogger = new StreamWriter(filepath, true);
            errorLogger.WriteLine($"[{DateTime.Now}] : {errorMessage}");
            errorLogger.Close();
        }
    }
}
