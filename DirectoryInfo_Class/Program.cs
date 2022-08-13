using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryInfo_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Created_By_C#";
             //dirObj will represent the directory.
            string path1 = @"E:\Moved_To_Another_Directory";
            DirectoryInfo dirObj = new DirectoryInfo(path1);

            //  dirObj.Create();
            //  dirObj.CreateSubdirectory("SubDirectory_Created");

            //dirObj.MoveTo(path1);
            dirObj.Delete(true);


            //Console.WriteLine(dirObj.FullName+" created");
            Console.WriteLine(dirObj.FullName + " created");
        }
    }
}
