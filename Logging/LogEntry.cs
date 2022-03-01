using System;

namespace LibElite.Logging
{
    public class LogEntry
    {
        public LogEntryType Type { get; set; }

        public DateTime Timestamp { get; set; }

        public string Module { get; set; }

        public string Submodule { get; set; }

        public string Message { get; set; }

        public string LongMessage { get; set; }

        public LogEntry()
        {
        }

        public LogEntry(LogEntryType type, string module, string submodule, string message, string longMessage)
        {
            Type = type;
            Module = module;
            Submodule = submodule;
            Message = message;
            Timestamp = DateTime.Now;
            LongMessage = longMessage;
        }
    }
}