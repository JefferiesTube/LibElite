using System.Runtime.CompilerServices;

namespace LibElite.Logging
{
    public abstract class LogWriterBase : Logger
    {
        private readonly Logger _logger;

        protected LogWriterBase(Logger parent)
        {
            _logger = parent;
        }

        public override void Log(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            _logger?.Log(module, submodule, message, longMessage);
        }

        public override void Hint(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            _logger?.Hint(module, submodule, message, longMessage);
        }

        public override void Warn(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            _logger?.Warn(module, submodule, message, longMessage);
        }

        public override void Error(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            _logger?.Error(module, submodule, message, longMessage);
        }
    }
}