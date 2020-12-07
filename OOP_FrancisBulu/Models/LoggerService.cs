using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FrancisBulu.Models
{
    public static class LoggerService
    {
        //variabele
        private static LogMessage[] logs = new LogMessage[0];
        //properties
        public static LogMessage[] Logs
        {
            get { return logs; }
            private set { logs = value; }
        }
        //process adding message
        static LoggerService()
        {
            logs = new LogMessage[0];
        }
        public static void AddLogMessage(LogMessage logMess)
        {
            Array.Resize(ref logs, logs.Length + 1);
            logs[logs.Length - 1] = logMess;
        }
    }
}
