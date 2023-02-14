using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace FileOperation2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path= @"C:\Users\user\Desktop";
            string myPath = "Deneme2";


            //string[] my

            DirectoryInfo directoryInfo= new DirectoryInfo(path);
            directoryInfo.CreateSubdirectory(myPath);

            //rectoryInfo.CreateSubdirectory();

        }

    }
}
