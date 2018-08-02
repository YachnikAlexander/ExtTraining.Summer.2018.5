using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution
{
    public class Service
    {
        private PrinterManager manager;

        public Service()
        {
            manager = new PrinterManager();
            ServiceCenter();
        }

        public string ServiceCenter()
        {
            Console.WriteLine("Select your choice:");
            Console.WriteLine("1:Add new printer");
            Console.WriteLine("2:Print on Canon");
            Console.WriteLine("3:Print on Epson");

            var key = Console.ReadKey();

            if (key.Key == ConsoleKey.D1)
            {
                return this.Add();
            }

            if (key.Key == ConsoleKey.D2)
            {
                this.Print(new CanonPrinter());
            }

            if (key.Key == ConsoleKey.D3)
            {
                this.Print(new EpsonPrinter());
            }

            while (true)
            {
                // waiting
            }
        }

        private string Add()
        {
            Console.WriteLine("Enter printer name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter printer model");
            string Model = Console.ReadLine();
            if(Model == "Canon")
            {
                return manager.Add(new CanonPrinter(Name, Model));
            }
            if(Model == "Epson")
            {
                return manager.Add(new EpsonPrinter(Name, Model));
            }
            return "there";
        }

        private string Print(Printer printer)
        {
            int[]data = manager.Print(printer);
            string dataString = "";
            for(int i = 0; i < data.Length; i++)
            {
                dataString += data[i].ToString();
            }
            return dataString;
        }

    }
}
