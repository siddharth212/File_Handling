using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Copy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"E:\Demo.txt";
            string path2 = @"E:\Demo1.txt";

            File.Copy(path1, path2);
          Console.ReadLine();
        }
    }
}
