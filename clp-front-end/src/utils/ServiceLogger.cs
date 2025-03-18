using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clp_front_end.src.utils
{
    public static class ServiceLogger
    {
        private static readonly string Source = "ClpFrontEndMessages";
        private static readonly string LogName = "Application";

        static ServiceLogger()
        {
            if (!EventLog.SourceExists(Source))
            {
                EventLog.CreateEventSource(Source, LogName);
            }
        }

        public static void Log(string message, EventLogEntryType type)
        {
            string safeMessage = message.Length > 30000 ? message.Substring(0, 30000) : message;
            EventLog.WriteEntry(Source, "CLP Front-End | " + safeMessage, type);
        }
    }
}
