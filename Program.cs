﻿using System;
using System.Net.Sockets;

namespace ConsoleClient
{
    class Program
    {
        
        static void Main(string[] args)
        {


            int closedPort = 0;
            string path = @"c:\report.csv";
            StreamWriter file = new StreamWriter(path, true);

            TcpClient client = new TcpClient();
            for (int port = 1; port <= 10; port++)
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


