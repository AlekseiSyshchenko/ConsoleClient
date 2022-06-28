using System;
using System.Net.Sockets;

namespace ConsoleClient
{
    class Program
    {
        
        static void Main(string[] args)
        {


            
            
            //FileService fileService = new FileService();
            StreamWriter file = FileService.getFile();

            //NetService netService = new NetService();
            TcpClient client = NetService.getClient();

            Scanner scanner = new Scanner(file, client);
            scanner.Scan();


        }
    }
}


