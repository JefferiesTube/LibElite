using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace LibElite.Logging
{
    [Flags]
    public enum LogEntryType
    {
        None = 0, Info = 1, Hint = 2, Warn = 4, Error = 8
    }

    public static class Logging
    {
        public static bool EnableStartupCache;

        public static Logger LogWriter { get; set; }

        private static readonly List<LogEntry> _cachedEntries;

        public static event Action OnLog;

        static Logging()
        {
            _cachedEntries = new List<LogEntry>();
        }

        public static List<LogEntry> RetrieveCache(bool keepCacheEnabled)
        {
            EnableStartupCache = keepCacheEnabled;

            List<LogEntry> localCopy = _cachedEntries.ToList();
            _cachedEntries.Clear();
            return localCopy;
        }

        private static T Construct<T>(Type[] paramTypes, params object[] paramValues)
        {
            ConstructorInfo ci = typeof(T).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public, null, paramTypes, null);
            return (T)ci.Invoke(paramValues);
        }

        public static T AttachLogger<T>() where T : Logger
        {
            T attachLogger = Construct<T>(new[] { typeof(T) }, LogWriter);
            LogWriter = attachLogger;
            return attachLogger;
        }

        public static T AttachLogger<T>(params object[] args) where T : Logger
        {
            Type[] types = new[] { typeof(T) }.Concat(args.Select(a => a.GetType())).ToArray();
            T attachLogger = Construct<T>(types, new object[] { LogWriter }.Concat(args).ToArray());
            LogWriter = attachLogger;
            return attachLogger;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Log(string message = null, string longMessage = "")
        {
            if(EnableStartupCache)
                _cachedEntries.Add(new LogEntry(LogEntryType.Info, Assembly.GetCallingAssembly().GetName().Name, new StackTrace().GetFrame(1).GetMethod().ReflectedType?.Name, message, longMessage));

            LogWriter?.Log(Assembly.GetCallingAssembly().GetName().Name, new StackTrace().GetFrame(1).GetMethod().ReflectedType?.Name, message, longMessage);
            OnLog?.Invoke();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Hint(string message = null, string longMessage = "")
        {
            if (EnableStartupCache)
                _cachedEntries.Add(new LogEntry(LogEntryType.Hint, Assembly.GetCallingAssembly().GetName().Name, new StackTrace().GetFrame(1).GetMethod().ReflectedType?.Name, message, longMessage));

            LogWriter?.Hint(Assembly.GetCallingAssembly().GetName().Name, new StackTrace().GetFrame(1).GetMethod().ReflectedType?.Name, message, longMessage);
            OnLog?.Invoke();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Warn(string message = null, string longMessage = "")
        {
            if (EnableStartupCache)
                _cachedEntries.Add(new LogEntry(LogEntryType.Warn, Assembly.GetCallingAssembly().GetName().Name, new StackTrace().GetFrame(1).GetMethod().ReflectedType?.Name, message, longMessage));

            LogWriter?.Warn(Assembly.GetCallingAssembly().GetName().Name, new StackTrace().GetFrame(1).GetMethod().ReflectedType?.Name, message, longMessage);
            OnLog?.Invoke();
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Error(string message = null, string longMessage = "")
        {
            if (EnableStartupCache)
                _cachedEntries.Add(new LogEntry(LogEntryType.Error, Assembly.GetCallingAssembly().GetName().Name, new StackTrace().GetFrame(1).GetMethod().ReflectedType?.Name, message, longMessage));

            LogWriter?.Error(Assembly.GetCallingAssembly().GetName().Name, new StackTrace().GetFrame(1).GetMethod().ReflectedType?.Name, message, longMessage);
            OnLog?.Invoke();
        }
    }
}
