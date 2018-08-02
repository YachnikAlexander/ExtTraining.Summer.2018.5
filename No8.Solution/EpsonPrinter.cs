using System;
using System.IO;
using System.Collections.Generic;


namespace No8.Solution
{
    public class EpsonPrinter : Printer
    {
        public override string Name { get; set; }
        public override string Model { get; set; }

        public EpsonPrinter()
        {
            Name = "";
            Model = "";
        }

        public EpsonPrinter(string name, string model) : base()
        {
            Name = name;
            Model = model;
        }

        public override int[] Print(FileStream fs)
        {
            int[] list = new int[fs.Length];
            for (int i = 0; i < fs.Length; i++)
            {
                list[i] = fs.ReadByte();
            }

            return list;
        }
    }
}
