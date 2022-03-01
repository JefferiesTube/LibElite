using System.Runtime.CompilerServices;

namespace LibElite.Logging
{
    public class Logger
    {
        public virtual void Log(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
        }

        public virtual void Hint(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
        }

        public virtual void Warn(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
        }

        public virtual void Error(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
        }
    }
}