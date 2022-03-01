using LibElite.PilotJournal.Events.Other;
using System.IO;
using System.Linq;
using System.Text;
using LibElite.Helper;

namespace LibElite.PilotJournal
{
    public class JournalWatcher
    {
        private readonly JournalReader _reader;
        private FileSystemPoller _poller;

        public JournalWatcher(JournalReader reader)
        {
            _reader = reader;
            if (reader.JournalExists)
            {
                SetupWatcher(reader.LatestJournal);
            }

            FileSystemWatcher newLogWatcher = new FileSystemWatcher(reader.JournalLocation)
            {
                NotifyFilter = NotifyFilters.CreationTime,
                Filter = "*.log"
            };
            newLogWatcher.Changed += NewLogCreated;
            newLogWatcher.EnableRaisingEvents = true;
            Logging.Logging.Log($"Setup Watcher for new logfiles");

            FileSystemWatcher statusWatcher = new FileSystemWatcher(reader.JournalLocation)
            {
                NotifyFilter = NotifyFilters.LastWrite,
                Filter = "status.json"
            };
            statusWatcher.Changed += StatusChanged;
            statusWatcher.EnableRaisingEvents = true;
            ReportInitialStatus(Path.Combine(reader.JournalLocation, "status.json"));
            Logging.Logging.Log($"Setup Watcher for status.json");

            FileSystemWatcher modulesWatcher = new FileSystemWatcher(reader.JournalLocation)
            {
                NotifyFilter = NotifyFilters.LastWrite,
                Filter = "ModulesInfo.json"
            };
            modulesWatcher.Changed += ModulesChanged;
            modulesWatcher.EnableRaisingEvents = true;
            ReportInitialModules(Path.Combine(reader.JournalLocation, "ModulesInfo.json"));
            Logging.Logging.Log($"Setup Watcher for ModulesInfo.json");
        }

        private void ReportInitialModules(string fileName)
        {
            if (!File.Exists(fileName))
            {
                Logging.Logging.Error($"Modules.Json not found. Cannot fully determine initial player state");
                return;
            }

            using (FileStream fs = File.OpenRead(fileName))
            {
                using (StreamReader rd = new StreamReader(fs))
                {
                    string data = rd.ReadToEnd();
                    if (!string.IsNullOrEmpty(data))
                    {
                        EventBase eventBase = _reader.ParseDirect(data, false);
                        if (eventBase != null)
                        {
                            ModuleInfo.Update((ModuleInfo)eventBase);
                        }
                    }
                }
            }
        }

        private void ModulesChanged(object sender, FileSystemEventArgs e)
        {
            using (FileStream fs = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string data = "";
                    while (!reader.EndOfStream)
                    {
                        data += reader.ReadLine();
                    }

                    if (!string.IsNullOrEmpty(data))
                    {
                        EventBase eventBase = _reader.ParseDirect(data, false);
                        if (eventBase != null)
                        {
                            ModuleInfo.Update((ModuleInfo)eventBase);
                        }
                    }
                }
            }
        }

        private void ReportInitialStatus(string fileName)
        {
            using (FileStream fs = File.OpenRead(fileName))
            {
                using (StreamReader rd = new StreamReader(fs))
                {
                    string data = rd.ReadToEnd();
                    if (!string.IsNullOrEmpty(data))
                    {
                        EventBase eventBase = _reader.ParseDirect(data, false);
                        if (eventBase != null)
                        {
                            Status status = (Status)eventBase;
                            status.Process(_reader.Notifications);
                        }
                    }
                }
            }
        }

        private void SetupWatcher(string fileName)
        {
            _poller?.Stop();
            Logging.Logging.Log($"Setup Watcher for {fileName}");
            _poller = new FileSystemPoller(fileName, 500);
            _poller.Changed += LogChanged;
            _poller.Start();
        }

        private void NewLogCreated(object sender, FileSystemEventArgs e)
        {
            Logging.Logging.Log($"New log file created. Updating file watcher");
            SetupWatcher(e.Name);
        }

        private void StatusChanged(object sender, FileSystemEventArgs e)
        {
            using (FileStream fs = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string data = "";
                    while (!reader.EndOfStream)
                    {
                        data += reader.ReadLine();
                    }

                    if (!string.IsNullOrEmpty(data))
                    {
                        EventBase eventBase = _reader.ParseDirect(data, false);
                        if (eventBase != null)
                        {
                            Status status = (Status)eventBase;
                            status.Process(_reader.Notifications);
                        }
                    }
                }
            }
        }

        private void LogChanged(string fullPath, long offset)
        {
            using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete))
            {
                fs.Seek(offset, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
                {
                    string[] newData = reader.ReadToEnd().Split('\n');
                    foreach (string journalEntry in newData.Where(j => !string.IsNullOrEmpty(j)))
                    {
                        EventBase eventBase = _reader.ParseDirect(journalEntry, true);
                        if (eventBase != null)
                        {
                            lock (_reader.Events)
                            {
                                _reader.Events.Add(eventBase);
                            }
                        }
                    }
                }
            }
        }
    }
}