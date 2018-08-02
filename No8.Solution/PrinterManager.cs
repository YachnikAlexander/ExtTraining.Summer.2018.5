using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace No8.Solution
{
    public class PrinterManager
    {
        private IRepository Repository;
        private ILogger logger;

        public event EventHandler<MsgForPrinterEventArgs> NewMsg = delegate { };

        #region Ctor
        public PrinterManager()
        {
            Repository = new FakeListRepository();
            logger = new DefaultLogger();
        }

        public PrinterManager(IEnumerable<Printer> printers)
        {
            Repository = new FakeListRepository();
            Repository.Save(printers);
            logger = new DefaultLogger();
        }

        public PrinterManager(IEnumerable<Printer> printers, ILogger logger)
        {
            Repository = new FakeListRepository();
            Repository.Save(printers);
            this.logger = logger;
        }

        public PrinterManager(IEnumerable<Printer> printers, IRepository repository)
        {
            Repository = repository;
            Repository.Save(printers);
            logger = new DefaultLogger();
        }

        public PrinterManager(IEnumerable<Printer> printers, IRepository repository, ILogger logger)
        {
            Repository = repository;
            Repository.Save(printers);
            this.logger = logger;
        }

        #endregion

        public string Add(Printer printer)
        {
            Repository.Save(printer);
            return "printer is added";
        }

        public int[] Print(Printer printer)
        {
            logger.Log("Print started");
            var o = new OpenFileDialog();
            o.ShowDialog();
            var f = File.OpenRead(o.FileName);
            int[] data = printer.Print(f);
            logger.Log("Print finished");

            return data;
        }

        public IEnumerable<Printer> GetPrinters()
        {
            return Repository.GetPrinters();
        }



    }
}
