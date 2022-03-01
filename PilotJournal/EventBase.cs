using System;

namespace LibElite.PilotJournal
{
    public class EventBase
    {
        public DateTime Timestamp { get; set; }

        public string Event { get; set; }
    }
}