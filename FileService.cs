using System;


namespace ConsoleClient
{
    internal class FileService
    {
        public static StreamWriter getFile()
        {
            StreamWriter file = new StreamWriter(Settings.path, true);
            return file;
        }

        

    }
}


