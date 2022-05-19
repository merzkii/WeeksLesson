using System;

namespace week10
{
    internal class Program
    {
        static void Main()
        {
            var readFileWorker = new ReadFileworker() { MaxFileSize = 128, WidthOfFile = "txt" };
            readFileWorker.read();
            readFileWorker.write();
            readFileWorker.edit();
            readFileWorker.delete();
            
            
        }
    }
}
