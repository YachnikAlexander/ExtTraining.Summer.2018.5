using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution
{
    public class CanonPrinter : Printer
    {
        public override string Name { get; set; }
        public override string Model { get; set; }

        public CanonPrinter()
        {
            Name = "";
            Model = "";
        }

        public CanonPrinter(string name, string model):base()
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
