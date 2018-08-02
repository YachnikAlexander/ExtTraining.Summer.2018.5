using System;
using System.IO;


namespace No8.Solution
{
    public class MsgForPrinterEventArgs : EventArgs
    {
        public FileStream FStream { get; private set; }

        public MsgForPrinterEventArgs(FileStream fileStream)
        {
            FStream = fileStream;
        }
    }
}
