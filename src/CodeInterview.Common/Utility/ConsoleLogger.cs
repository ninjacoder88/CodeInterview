using System;
using CodeInterview.Common.Interfaces;

namespace CodeInterview.Common.Utility
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}