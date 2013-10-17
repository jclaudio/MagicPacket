using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace MagicPacket_Shared
{
    public class Net
    {
        const int DEFAULT_PORT = 9;

        int destinationPort;
        string destinationAddress;

        public static void SendPacket(byte[] dataPacket)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, DEFAULT_PORT);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            for (int i = 0; i < dataPacket.Length; i++)
            {
                socket.SendTo(dataPacket, endPoint);
            }
        }

    }
}
