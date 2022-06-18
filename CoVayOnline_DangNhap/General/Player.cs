using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;

namespace General
{
    public class Player
    {
        public string name{get;set;}
        public string ipaddress { get; set; }
        public Socket socket { get; set; }
        public Room room { get; set; }
    }
}
