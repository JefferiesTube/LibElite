using System;
using System.IO;
using System.Threading;

namespace LibElite.Helper
{
    public class FileSystemPoller
    {
        private readonly string _observedFilePath;
        private readonly int _intervalInMSec;

        private long _lastObservedFileSize;

        public event Action<string, long> Changed;

        private bool _active;
        private Thread _observer;

        public FileSystemPoller(string fullPath, int intervalInMSec)
        {
            _observedFilePath = fullPath;
            _intervalInMSec = intervalInMSec;
        }

        public void Start()
        {
            if (_active)
                _observer?.Abort();
            _observer = new Thread(ObserveFile) { IsBackground = true };
            _active = true;
            _observer.Start();
        }

        public void Stop()
        {
            _active = false;
        }

        private void ObserveFile()
        {
            _lastObservedFileSize = GetFileSize();

            while (_active)
            {
                Thread.Sleep(_intervalInMSec);
                long newFileSize = GetFileSize();
                if (newFileSize != _lastObservedFileSize)
                {
                    Changed?.Invoke(_observedFilePath, _lastObservedFileSize);
                    _lastObservedFileSize = newFileSize;
                }
            }
        }

        private long GetFileSize()
        {
            using (FileStream fs = new FileStream(_observedFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite | FileShare.Delete))
            {
                return fs.Length;
            }
        }
    }
}