﻿using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Travel
{
    [EventType("LeaveBody")]
    public class LeaveBody : EventBase
    {
        public string StarSystem { get; set; }
        public long SystemAddress { get; set; }
        public string Body { get; set; }
        public long BodyID { get; set; }
    }
}