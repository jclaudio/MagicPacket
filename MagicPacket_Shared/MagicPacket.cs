using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicPacket_Shared
{
    public class MagicPacket
    {
        const byte TRAILER = 0xFF;

        string computerName;
        string macAddress_string;
        byte[] macAddres_bytes;

        public MagicPacket(string computerName, string macAddress)
        {
            this.computerName = computerName;
            this.macAddress_string = macAddress;
            macAddres_bytes = convertToBytes(macAddress_string);
        }

        public MagicPacket(Computer computer)
        {
            this.computerName = computer.Name;
            this.macAddress_string = computer.MAC;
            macAddres_bytes = convertToBytes(macAddress_string);
        }

        private byte[] buildPacket(byte[] macAddress)
        {
            List<byte> packetBuilder = new List<byte>();

            for (int i = 0; i < 6; i++)     // 0xFF trailer
            {
                packetBuilder.Add(TRAILER);
            }

            for (int i = 0; i < 16; i++)    // MAC address 16 times
            {
                packetBuilder.AddRange(macAddres_bytes);
            }

            return packetBuilder.ToArray();
        }

        private byte[] convertToBytes(string input)
        {
            System.Text.Encoding encoder = System.Text.Encoding.ASCII;
            return encoder.GetBytes(macAddress_string);
        }

        public override string ToString()
        {
            return "Computer: " + computerName
                 + "MAC Address: " + macAddress_string;
        }
    }
}
