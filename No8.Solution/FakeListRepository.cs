using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution
{
    public class FakeListRepository : IRepository
    {
        private List<Printer> printers;

        public void Save(IEnumerable<Printer> printers)
        {
            foreach(var printer in printers)
            {
                this.printers.Add(printer);
            }
        }

        public void Save(Printer printer)
        {
            printers.Add(printer);
        }

        public IEnumerable<Printer> GetPrinters()
        {
            return printers;
        }
    }
}
