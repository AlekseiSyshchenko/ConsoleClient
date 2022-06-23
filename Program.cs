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

                
                
                   //String fileName = $"report{server}.csv";
                   //FileInfo fileInfo = new FileInfo(@$"report{ip}.csv");
                   //StreamWriter report = fileInfo.CreateText();
                   File.Create($"report{ip}.csv");
                
                
                try
                {
                   
                   TcpClient client = new TcpClient();
                   for(int port = 1; port <= 65535; port++)
                   {
                        closedPort = port;
                        client.Connect(ip, port); 
                        //report.WriteLine($"{DateTime.Now}, {ip}, {port}, Open");
                        File.WriteAllText($"report{ip}.csv", $"{DateTime.Now}, {ip}, {port}, Open");
                        client.Close();
                   }
                   
                }
                catch (SocketException e)
                {
                    File.WriteAllText($"report{ip}.csv", $"{DateTime.Now}, {ip}, {closedPort}, Close");
                    //report.WriteLine($"{DateTime.Now}, {ip}, {closedPort}, Close");
                    //Console.WriteLine("SocketException: {0}", e);
                }
        }
    }
}
    

