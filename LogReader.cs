using System;
using System.IO;

namespace LogReader
{
    public class LogReader
    {
        public string LogFilePath { get; set; }

        //public string ReadLogFile()
        //{
        //    return File.ReadAllText(LogFilePath);
        //}

        public string ReadLogFile()
        {
            using (FileStream fs = File.Open(LogFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (StreamReader reader = new StreamReader(fs))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
