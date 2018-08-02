using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No8.Solution
{
    public interface IRepository
    {
        void Save(IEnumerable<Printer> printers);
        void Save(Printer printer);
        IEnumerable<Printer> GetPrinters()
    }
}
