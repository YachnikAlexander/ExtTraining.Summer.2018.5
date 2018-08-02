using System;
using System.IO;
namespace No8.Solution
{
    public abstract class Printer
    {
        public abstract int[] Print(FileStream fs);

        public abstract string Name { get; set; }

        public abstract string Model { get; set; }

        public Printer() { }

        //public abstract void Register(MsgForPrinterEventArgs msg);

        //public abstract void Unregister(MsgForPrinterEventArgs msg);
    }
}
