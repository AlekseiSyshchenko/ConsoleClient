using System;
using System.Net.Sockets;

namespace ConsoleClient
{
    class Program
    {
        const string ip = "87.250.250.242";
        static void Main(string[] args)
        {


            int closedPort = 0;
            string path = @"c:\report.csv";
            System.IO.StreamWriter file = new System.IO.StreamWriter(path);

            try
            {

                TcpClient client = new TcpClient();

                for (int port = 1; port <= 65535; port++)
                {
                    Console.WriteLine($"Я в цикле {port}");
                    closedPort = port;
                    client.Connect(ip, port);
                    Console.WriteLine("Open");
                    file.WriteLine($"{DateTime.Now}, {ip}, {port}, Open");
                    client.Close();
                }

            }

            catch (SocketException e)
            {
                Console.WriteLine($"Я в catch {closedPort}");
                Console.WriteLine("Close");
                file.WriteLine($"{DateTime.Now}, {ip}, {closedPort}, Close");

            }
        }
    }
}


