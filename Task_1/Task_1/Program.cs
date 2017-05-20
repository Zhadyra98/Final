using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\user\final_2017\Task1");
            FileInfo[] files = dir.GetFiles();
            foreach(FileInfo f in files)
            {
                Console.WriteLine(f.Name);
            }
            Console.ReadKey();
        }
    }
}
