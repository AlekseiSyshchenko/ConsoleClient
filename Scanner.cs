using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace ConsoleClient
{
    internal class Scanner
    {
        StreamWriter file;
        TcpClient client;

        public Scanner(StreamWriter file, TcpClient client)
        {
            this.file = file;
            this.client = client;
        }
        int closedPort = 0;
        public void Scan()
        {
            for (int port = 1; port <= 5; port++)
            {

                try
                {


                    closedPort = port;
                    client.Connect(Settings.ip, port);
                    Console.WriteLine($"{port} Open");
                    file.WriteLine($"{DateTime.Now}, {Settings.ip}, {port}, Open");
                    client.Close();

                }

                catch (SocketException e)
                {

                    Console.WriteLine($"{port} Close");
                    file.WriteLine($"{DateTime.Now}, {Settings.ip}, {closedPort}, Close");

                }
            }

            file.Close();
        }
    }
}
