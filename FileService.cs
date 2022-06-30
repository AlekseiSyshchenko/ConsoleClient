using System;


namespace ConsoleClient
{
    internal class FileService : IDisposable
    {
        private static StreamWriter file = new StreamWriter(Settings.path, true);

        public void Dispose()
        {
            
        }

        public void WriteOpen(int port)
        {
            file.WriteLine($"{DateTime.Now}, {Settings.ip}, {port}, Open");
        }
       
        public void WriteClose(int port)
        {
            file.WriteLine($"{DateTime.Now}, {Settings.ip}, {port}, Close");
        }

        public void CloseFile()
        {
            file.Close();
        }

    }
}


