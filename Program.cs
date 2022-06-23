using System;
using System.Net.Sockets;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter ip address (for exit enter q): ");
            int port = 80;
            string server = Console.ReadLine();
            while (server != "q" && server != "Q")
            {
                try
                {
                   TcpClient client = new TcpClient();
                   client.Connect(server, port); 
                   Console.WriteLine("Connection establised");
                   client.Close();
                   Console.WriteLine("Connection closed");
                   Console.WriteLine();
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                }

                
                Console.Write("Enter ip address for new connection (or q): ");
                server = Console.ReadLine();
                //comment
        
            }
        }
    }
}
