using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicPacket_Shared;

namespace MagicPacket_Console
{
    public class Wake
    {
        Computer computer;
        MagicPacket packet;

        public Wake(string macAddress)
        {
            computer = new Computer("Computer at ", macAddress);
        }

        //public Wake(Computer computer)
        //{
        //    this.computer = computer;
        //}

        public void wake()
        {
            try
            {
                createPacket();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            try
            {
                sendPacket(packet.getPacket());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void createPacket() 
        {
            packet = new MagicPacket(computer);
        }

        private void sendPacket(byte[] magicPacket)
        {
            Net.SendPacket(magicPacket);
        }
    }
}
