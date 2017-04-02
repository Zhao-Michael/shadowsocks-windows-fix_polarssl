﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using SimpleJson;

namespace Shadowsocks.Model
{
    [Serializable]
    public class Server
    {
        public string server;
        public int server_port;
        public int local_port = 1080;
        public string password;
        public string method;
        public string remarks;
    }
}
