using System;
using System.Net.Sockets;


namespace ConsoleClient
{
    internal class NetService
    {
        private TcpClient client = new TcpClient();
        public TcpClient Client { get; }

    }
}
