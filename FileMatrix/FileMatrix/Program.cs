using System;
using System.IO;
namespace FileMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] dd = DriveInfo.GetDrives();
            foreach (DriveInfo d in dd) { Console.WriteLine(d); }
            var data = Directory.CreateDirectory(@"C:\Users\user\Desktop\Yeni klasör\temp.txt");

            DirectoryInfo direct = new DirectoryInfo(@"C:\Users\user\Desktop\Yeni klasör\temp.txt");
            //direct.Create();
            FileInfo[] info = direct.GetFiles();
            foreach (FileInfo fi in info)
            {
                Console.WriteLine(fi);
            }
        }
    }
}
