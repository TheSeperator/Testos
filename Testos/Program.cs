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
            var meineSchwimmers = new ISwimable[] { new Ente(), new Fisch() };

            foreach (var schwimmer in meineSchwimmers)
            {
                schwimmer.Schwimmen();
            }

            Console.ReadLine();
        }
    }
}
