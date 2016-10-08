using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testos
{
    class Ente : ISwimable
    {
        public void Quak()
        {
            Console.WriteLine("Quak");
        }

        public void Schwimmen()
        {
            Console.WriteLine("Schwmm Schwimm :)");
        }
    }
}
