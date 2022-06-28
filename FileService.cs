using System;


namespace ConsoleClient
{
    internal class FileService
    {
        private StreamWriter file = new StreamWriter(Settings.path, true);
        public StreamWriter File { get; }
        public void Close() => file.Close();
    }
}
