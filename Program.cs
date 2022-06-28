using System;
using System.Net.Sockets;

namespace ConsoleClient
{
    class Program
    {
        
        static void Main(string[] args)
        {


            
            
            FileService fileService = new FileService();
            StreamWriter file = fileService.File;

            NetService netService = new NetService();
            TcpClient client = netService.Client;

            Scanner scanner = new Scanner(ref file, ref client);
            scanner.Scan();

            fileService.Close();


        }
    }
}


