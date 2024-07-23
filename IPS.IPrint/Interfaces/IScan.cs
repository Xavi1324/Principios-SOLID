using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Document.Interfaces
{
    public interface IScan : IPrint
    {
        public void Scan(string text);

    }
}
