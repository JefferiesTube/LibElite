using LibElite.PilotJournal.Converter;

namespace LibElite.PilotJournal.Events.Startup
{
    [EventType("Friends")]
    public class Friends : EventBase
    {
        public FriendStatus Status { get; set; }

        public string Name { get; set; }
    }
}