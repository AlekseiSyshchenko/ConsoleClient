using System;
using System.Net.Sockets;


namespace ConsoleClient
{
    class NetService
    {



        public static void ScanPort()
        {
            int closedPort = 0;
            using (FileService fileService = new FileService())
            using (TcpClient client = new TcpClient())
            {

                for (int port = 1; port <= 5; port++)
                {

                    try
                    {


                        closedPort = port;
                        client.Connect(Settings.ip, port);
                        Console.WriteLine($"{port} Open");
                        fileService.WriteOpen(port);
                        client.Close();

                    }

                    catch (SocketException e)
                    {

                        Console.WriteLine($"{port} Close");
                        fileService.WriteClose(closedPort);

                    }

                }

                fileService.CloseFile();
            }
        }
    }
}
