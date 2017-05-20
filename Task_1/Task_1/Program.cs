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
    
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\user\Final\Task1");
            FileInfo[] files = dir.GetFiles();
            foreach(FileInfo f in files)
            {
                StreamReader sr = new StreamReader(f.FullName);
                string k = sr.ReadLine();
                string[] k1 = k.Split();
                int count = 0;
                int a = int.Parse(k1[0]);
                int b = int.Parse(k1[1]);

                int l = Math.Min(a, b);
                for (int i=1; i<l; i++)
                {
                    if(a%i==0 && b % i == 0)
                    {
                        count++;
                    }
                }
               Console.Write(f.Name+" ");
                if (count == 1)
                {
                    Console.WriteLine("yes");

                }
                else
                {
                    Console.WriteLine("no");
                }              
                sr.Close();
            }
            
            Console.ReadKey();
        }
    }
}
