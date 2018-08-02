using System;
using System.IO;

namespace No8.Solution
{
    public class DefaultLogger : ILogger
    {
        public void Log(string s)
        {
            File.AppendText("log.txt").Write(s);
        }
    }
}
