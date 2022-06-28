using System;
using System.Net.Sockets;


namespace ConsoleClient
{
    internal class NetService
    {
        public static TcpClient getClient()
        {
            TcpClient client = new TcpClient();
            return client;
        }
    }
}
