using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace FileOperations
{
    internal class Program
    {
        public static string readerTask1(string txt)
        {
            string newtext = null;
            
            for (int i = 0; i < ((txt.Length) - 5); i++)
            {
                newtext += txt[i].ToString();
            }
            string[] data = newtext.Split(" ");
            string newText = data[0] + "\n " + " " + "\n" + data[2]+"\n";
            return newText;
        }

        static void Main(string[] args)
        {
            //FileInfo fi = new FileInfo(path);
            //fi.AppendText(); bu text harda yaziriq?
            // Directory.CreateDirectory(args[0]); bu ne olur ki?
            //DirectoryInfo directory= new DirectoryInfo(args[0]); bu ne? args[0]
            //.txt hisesini almag ucun method var?

            //yersiz strart verende fileler olusacaq ve qarisiqliq olacaq...
            Console.WriteLine("Hello World!");

            #region Task1
            string path = @"C:\Users\user\source\repos\MatrixHomeWorks\FileOperations\Works\Task1";
            try
            {
                

                string txt1 = File.ReadAllText(Path.Combine(path, "File1.txt"));
                string txt2 = File.ReadAllText(Path.Combine(path, "File2.txt"));
                string txt3 = File.ReadAllText(Path.Combine(path, "File3.txt"));
                string allText;
                allText = readerTask1(txt1);
                allText += readerTask1(txt2);
                allText += readerTask1(txt3);

                if (File.Exists(Path.Combine(path, "File4.txt")) == false)
                {
                    File.Create(Path.Combine(path, "File4.txt"));//file4 olmayanda xeta verdi icaze xetasi bunu task ikidedki kimi etiket ile hell elemeye olar yeqin
                    File.WriteAllText(Path.Combine(path, "File4.txt"), allText, System.Text.Encoding.Default);
                    //encoding deyesen icazedi???

                    
                }
                else
                {
                    File.WriteAllText(Path.Combine(path, "File4.txt"), allText, System.Text.Encoding.Default);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());   
            }

            

            #endregion

            #region Task2
            string path2 = @"C:\Users\user\source\repos\MatrixHomeWorks\FileOperations\Works\Task2";
            string directoryName = "sadruh";
            string fileName = "episode1";
            fileName = fileName + ".txt";

            elsetoif:
            if (Directory.Exists(Path.Combine(path2, directoryName)) == true)
            {
                File.Create(Path.Combine(path2, directoryName, fileName));
            }
            else
            {
                Directory.CreateDirectory(Path.Combine(path2, directoryName));
                DateTime dt = Directory.GetCreationTime(Path.Combine(path2, directoryName));
                Console.WriteLine($"{ directoryName} was created: " + dt.ToString());
                goto elsetoif;
            }

            #endregion

            #region Task3

            //MoveAllfiles();

            #endregion

            #region Task1Ugursuz
            Directory.CreateDirectory(path + "Task1");
            path = path + "Task1";
            string[] fileNamee = { "File1.txt", "File2.txt", "File3.txt" };
            //string[] infoo = { "İlham Abbasov 239103ASD 1993", "NAme Surname 231998ADE 1992", "Teymur Mammadov 4785965DEF 1995" };
            List<string> info = new List<string> { "İlham Abbasov 239103ASD 1993", "NAme Surname 231998ADE 1992", "Teymur Mammadov 4785965DEF 1995" };
            string[] newPath = new string[fileNamee.Length];

            for (int i = 0; i < fileName.Length; i++)
            {
                newPath[i] = Path.Combine(path, fileNamee[i]);
            }

            for (int i = 0; i < newPath.Length; i++)
            {
                using (FileStream fs = new FileStream(newPath[i], FileMode.Open, FileAccess.Write))
                {
                    StreamWriter streamWriter = new StreamWriter(fs);

                    if (File.Exists(newPath[i]))
                    {
                        //FileInfo fi = new FileInfo(newPath[i]);
                        //fi.Delete();
                        //fi.Create();
                        //File.Delete(newPath[i]);
                        //File.Create(newPath[i]);


                        if (i == 0)
                        {
                            streamWriter.WriteLine(info[i]);
                            streamWriter.Close();
                            //File.WriteAllText(newPath[i], info[i], System.Text.Encoding.Default);
                        }
                        else if (i == 1)
                        {
                            streamWriter.WriteLine(info[i]);
                            streamWriter.Close();
                            //File.WriteAllText(newPath[i], info[i], System.Text.Encoding.Default);
                        }
                        else
                        {
                            streamWriter.WriteLine(info[i]);
                            streamWriter.Close();
                            //File.WriteAllText(newPath[i], info[i], System.Text.Encoding.Default);
                        }


                    }
                    else
                    {
                        File.Create(newPath[i]);

                        if (i == 0)
                        {
                            streamWriter.WriteLine(info[i]);
                            streamWriter.Close();
                            //File.WriteAllText(newPath[i], info[i], System.Text.Encoding.Default);
                        }
                        else if (i == 1)
                        {
                            streamWriter.WriteLine(info[i]);
                            streamWriter.Close();
                            //File.WriteAllText(newPath[i], info[i], System.Text.Encoding.Default);
                        }
                        else
                        {
                            streamWriter.WriteLine(info[i]);
                            streamWriter.Close();
                            //File.WriteAllText(newPath[i], info[i], System.Text.Encoding.Default);
                        }
                    }
                }
            }
            #endregion
        }

        public static void MoveAllfiles()
        {
            string path3 = @"C:\Users\user\source\repos\MatrixHomeWorks\FileOperations\Works\Task3";
            string path3BU = @"C:\Users\user\source\repos\MatrixHomeWorks\FileOperations\Works\Task3\BackUp";
            
            DateTime file1Date = File.GetCreationTime(Path.Combine(path3, "File1.txt"));
            string file1NewName = $"File1{file1Date.ToString("yyyy-mm-dd")}.txt";
            DateTime file2Date = File.GetCreationTime(Path.Combine(path3, "File2.txt"));
            string file2NewName = $"File2{file2Date.ToString("yyyy-mm-dd")}.txt";
            DateTime file3Date = File.GetCreationTime(Path.Combine(path3, "File3.txt"));
            string file3NewName = $"File3{file3Date.ToString("yyyy-mm-dd")}.txt";
            DateTime file4Date = File.GetCreationTime(Path.Combine(path3, "File4.txt"));
            string file4NewName = $"File4{file4Date.ToString("yyyy-mm-dd")}.txt";
            

            //file1NewName = "File1" + File.GetCreationTime(Path.Combine(path3, "File1.txt") + ".txt";

            //File.Move(Path.Combine(path3, "File1.txt"), Path.Combine(path3, "BackUp", file1NewName));
            File.Move(Path.Combine(path3, "File1.txt"), Path.Combine(path3BU, file1NewName));
            File.Move(Path.Combine(path3, "File2.txt"), Path.Combine(path3BU, file2NewName));
            File.Move(Path.Combine(path3, "File3.txt"), Path.Combine(path3BU, file3NewName));
            File.Move(Path.Combine(path3, "File4.txt"), Path.Combine(path3BU, file4NewName));

        }

    }
}
