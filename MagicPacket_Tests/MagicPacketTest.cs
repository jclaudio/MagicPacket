using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MagicPacket_Shared;

namespace MagicPacket_Tests
{
    [TestClass]
    public class MagicPacketTest
    {
        [TestMethod]
        public void ToStringTest()
        {
            MagicPacket packet = new MagicPacket("test", "macTest");
            Console.WriteLine(packet.ToString());
        }
    }
}
