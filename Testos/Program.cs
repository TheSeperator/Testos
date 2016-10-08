using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testos
{
    class Program
    {
        static void Main(string[] args)
        {
            Ente meineEnte = new Testos.Ente();
            meineEnte.Quak();
            meineEnte.Schwimmen();
            Console.ReadLine();
        }
    }
}
