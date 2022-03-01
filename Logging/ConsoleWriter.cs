using System;
using System.Runtime.CompilerServices;

namespace LibElite.Logging
{
    public class ConsoleWriter : LogWriterBase
    {
        public ConsoleWriter(Logger parent) : base(parent)
        {
        }

        public override void Log(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"[{module}::{submodule}] {message} : {longMessage}");
            base.Log(module, submodule, message, longMessage);
        }

        public override void Hint(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"[{module}::{submodule}] {message} : {longMessage}");
            base.Hint(module, submodule, message, longMessage);
        }

        public override void Warn(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[{module}::{submodule}] {message} : {longMessage}");
            base.Warn(module, submodule, message, longMessage);
        }

        public override void Error(string module = null, [CallerMemberName] string submodule = null, string message = null, string longMessage = "")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[{module}::{submodule}] {message} : {longMessage}");
            base.Error(module, submodule, message, longMessage);
        }
    }
}