using LibElite.PilotJournal.Converter;
using LibElite.PilotJournal.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LibElite.Annotations;

namespace LibElite.PilotJournal
{
    public delegate void JournalLoadProgressHandler(int currentStep, int stepOverall, double currentProgress);

    public class JournalReader : INotifyPropertyChanged
    {
        private readonly Dictionary<string, Type> EventTypeMap;
        private readonly Regex EventRegex;
        private readonly JsonSerializerSettings SerializerSettings;
        public string JournalLocation;
        private ObservableCollection<EventBase> _events;
        private string _latestJournal;
        private JournalNotifications _notifications;

        public bool JournalExists => Directory.Exists(JournalLocation);

        public virtual ObservableCollection<EventBase> Events
        {
            get => _events;
            protected set
            {
                _events = value; 
                OnPropertyChanged();
            }
        }

        public string LatestJournal
        {
            get => _latestJournal;
            private set
            {
                _latestJournal = value;
                OnPropertyChanged();
            }
        }

        public JournalNotifications Notifications
        {
            get => _notifications;
            private set
            {
                _notifications = value;
                OnPropertyChanged();
            }
        }

        public event Action<EventBase> OnNewEvent;

        public event JournalLoadProgressHandler OnLoadProgress;

        public event Action OnLoadCompleted;

        public JournalReader(string journalLocation = null)
        {
            JournalLocation = string.IsNullOrEmpty(journalLocation) ? Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"Saved Games\Frontier Developments\Elite Dangerous\") : journalLocation;

            EventTypeMap = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes().Where(myType =>
                    myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(EventBase))))
                .ToDictionary(type => type.GetCustomAttribute<EventTypeAttribute>().Type.ToLowerInvariant(), type => type);
            EventRegex = new Regex("\"event\":\\s?\"(\\w+)\"", RegexOptions.Multiline | RegexOptions.Compiled);
            SerializerSettings = new JsonSerializerSettings()
            {
#if DEBUG
                MissingMemberHandling = MissingMemberHandling.Error
#endif
            };

            Events = new ObservableCollection<EventBase>();
            Notifications = new JournalNotifications();
        }

        public void ReadJournalFast()
        {
            const int stepCount = 4;
            OnLoadProgress?.Invoke(0, stepCount, 0);
            Regex rx = new Regex(@"\w+.(\d+).(\d+).log");

            List<EventBase> newEvents = new List<EventBase>();

            string[] files = Directory.GetFiles(JournalLocation, "Journal*.log")
                .OrderBy(f => rx.Match(f).Groups[1].Value)
                .ThenBy(f => rx.Match(f).Groups[2].Value).ToArray();

            if (!JournalExists || !files.Any())
                return;

            LatestJournal = files.Last();

            OnLoadProgress?.Invoke(1, stepCount, 0);
            List<string[]> logs = new List<string[]>();
            logs = files.Select(ReadAllLines).AsParallel().ToList();

            OnLoadProgress?.Invoke(2, stepCount, 0);
            int allLogs = logs.Sum(l => l.Length);
            int current = 0;
            Parallel.ForEach(logs, log =>
            {
                List<EventBase> threadEvents = new List<EventBase>();
                StringBuilder sb = new StringBuilder();
                for (int index = 0; index < log.Length; index++)
                {
                    if (++current % 100 == 0)
                        OnLoadProgress?.Invoke(3, stepCount, current / (allLogs * 1.0));
                    sb.Append(log[index]);
                    while (sb[sb.Length - 1] != '}')
                    {
                        index++;
                        sb.Append(log[index]);
                    }
                    EventBase e = ParseDirect(sb.ToString(), false);
                    if (e != null)
                        threadEvents.Add(e);
                    sb.Clear();
                }
                lock (newEvents)
                    newEvents.AddRange(threadEvents);
            });

            lock (Events)
            {
                foreach (EventBase e in newEvents.OrderBy(e => e?.Timestamp))
                {
                    Events.Add(e);    
                }
            }

            Events.CollectionChanged += delegate (object sender, NotifyCollectionChangedEventArgs args)
            {
                if (args.Action == NotifyCollectionChangedAction.Add)
                {
                    foreach (EventBase newEvent in args.NewItems.Cast<EventBase>())
                    {
                        OnNewEvent?.Invoke(newEvent);
                    }
                }
            };
            OnLoadProgress?.Invoke(stepCount, stepCount, 1);
            OnLoadCompleted?.Invoke();
        }
        
        public EventBase ParseDirect(string data, bool allowLogging)
        {
            Type eventType = EventTypeMap[EventRegex.Match(data).Groups[1].Value.ToLowerInvariant()];
            try
            {
                return (EventBase)JsonConvert.DeserializeObject(data, eventType, SerializerSettings);
            }
            catch (JsonSerializationException e)
            {
                Logging.Logging.Error($"Journal Error loading {eventType}", e.Message);
                return null;
            }
        }

        private string[] ReadAllLines(string fileName)
        {
            List<string> result = new List<string>();
            using (FileStream fileStream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (streamReader.Peek() > -1)
                    {
                        result.Add(streamReader.ReadLine());
                    }
                }
            }

            return result.ToArray();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}