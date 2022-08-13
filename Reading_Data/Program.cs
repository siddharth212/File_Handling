using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reading_Data
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Demo.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Found");
                string result = File.ReadAllText(path);
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("File Not Found..");
            }
        }
    }
}
