using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicPacket_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                Wake wake = new Wake(args[0]);
                wake.wake();
            }
            else
            {
                Console.WriteLine("Usage: wake [mac address]");
            }
        }
    }
}
