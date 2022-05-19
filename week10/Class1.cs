using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10
{

    public abstract class FileWorker
    {
        public int MaxFileSize { get; set; }
        public abstract string WidthOfFile { get; set; }
        public abstract void read();
        public abstract void write();
        public abstract void edit();
        public abstract void delete();



    }


    public class ReadFileworker : FileWorker
    {
        public override string WidthOfFile { get; set; }



        public override void read()
        {
            Console.WriteLine($"i can read from {WidthOfFile} file with max storage {MaxFileSize}");
        }
        public override void write()
        {
            Console.WriteLine($"i can write from {WidthOfFile} file with max storage {MaxFileSize}");
        }
        public override void edit()
        {
            Console.WriteLine($"i can edit from {WidthOfFile} file with max storage {MaxFileSize}");
        }
        public override void delete()
        {
            Console.WriteLine($"i can delete from {WidthOfFile} file with max storage {MaxFileSize}");
        }

    }

}




    

    