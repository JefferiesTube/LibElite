using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace LibElite.Logging
{
    public class TextFileWriter : LogWriterBase
    {
        private readonly string _fileName;

        private readonly bool _prependCategory;

        protected TextFileWriter(Logger parent, string fileName, bool prependCategory) : base(parent)
        {
            _fileName = fileName;
            _prependCategory = prependCategory;
            lock (this)
            {
                File.WriteAllText(fileName, string.Empty);
            }
        }

        public override void Log(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            lock (this)
            {
                File.AppendAllText(_fileName, (_prependCategory ? "[INFO] " : string.Empty) + $"[{module}::{submodule}] {message}{(string.IsNullOrEmpty(longMessage) ? string.Empty : " : " + longMessage)}" + Environment.NewLine);
            }

            base.Log(module, submodule, message, longMessage);
        }

        public override void Hint(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            lock (this)
            {
                File.AppendAllText(_fileName, (_prependCategory ? "[HINT] " : string.Empty) + $"[{module}::{submodule}] {message}{(string.IsNullOrEmpty(longMessage) ? string.Empty : " : " + longMessage)}" + Environment.NewLine);
            }

            base.Hint(module, submodule, message, longMessage);
        }

        public override void Warn(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            lock (this)
            {
                File.AppendAllText(_fileName, (_prependCategory ? "[WARN] " : string.Empty) + $"[{module}::{submodule}] {message}{(string.IsNullOrEmpty(longMessage) ? string.Empty : " : " + longMessage)}" + Environment.NewLine);
            }

            base.Warn(module, submodule, message, longMessage);
        }

        public override void Error(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            lock (this)
            {
                File.AppendAllText(_fileName, (_prependCategory ? "[ERROR] " : string.Empty) + $"[{module}::{submodule}] {message}{(string.IsNullOrEmpty(longMessage) ? string.Empty : " : " + longMessage)}" + Environment.NewLine);
            }

            base.Error(module, submodule, message, longMessage);
        }
    }
}