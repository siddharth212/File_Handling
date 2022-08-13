using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling__
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Demo.txt";

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Doesn't Exist");
            }
        }
    }
}
