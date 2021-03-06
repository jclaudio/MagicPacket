﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicPacket_Shared
{
    /// <summary>
    /// Class that describes a computer object
    /// </summary>
    public class Computer
    {
        string computerName;
        string macAddress;

        public Computer(string name, string macAddress)
        {
            this.computerName = name;
            this.macAddress = macAddress;
        }

        public string Name
        {
            get;
            set;
        }

        public string MAC
        {
            get;
            set;
        }
    }
}
