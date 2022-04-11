using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SamplePlaybook
{
    public class LogToFileHelper : ILoggingService
    {
        string fileName = @"C:\SamplePlayController\SamplePlay.txt";
        public void LogMessage(string message)
        {
            
            //Log to file in local file system
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(message);
                    }
                }
                
            }
        }
    }
}
