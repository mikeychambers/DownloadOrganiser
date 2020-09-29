using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DownloadOrganiser
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] imageFiles = { ".jpg", ".jpeg", ".jpe", ".jif", ".jfif", ".jfi" ,".png", ".gif", ".webp", ".tiff", ".tif",
                ".psd", ".raw", ".arw", ".cr2", ".nrw", ".k25", ".bmp", ".dib", ".heif", ".heic", ".ind", ".indd", ".indt", ".jp2", ".j2k", ".jpf", ".jpx", ".jpm", ".mj2",
                ".svg", ".svgz", ".ai", ".eps"};
            string[] videoFiles = { ".webm", ".mpg", ".mp2", ".mpeg", ".mpe", ".mpv", ".ogg", ".mp4", ".m4p", ".m4v", ".avi", ".wmv", ".mov", ".qt", ".flv", ".swf", ".avchd", ".mkv" };
            string[] exeFiles = { ".exe", ".iso", ".msi" };
            string[] files = Directory.GetFiles($@"C:\Users\{Environment.UserName}\Downloads");

/*

            foreach (var item in files)
            {
                FileInfo fi = new FileInfo(item);

                if (exeFiles.Contains(fi.Extension) && !Directory.Exists($@"C:\Users\{Environment.UserName}\Documents\Exes"))
                {
                    Console.WriteLine($@"Executables have been detected and will be moved to C:\Users\{Environment.UserName}\Documents\Exes Press enter");
                    Console.ReadLine();
                    Directory.CreateDirectory($@"C:\Users\{Environment.UserName}\Documents\Exes");
                    File.Move(item, $@"C:\Users\{Environment.UserName}\Documents\Exes\" + Path.GetFileName(item));
                }

                else if (exeFiles.Contains(fi.Extension) && Directory.Exists($@"C:\Users\{Environment.UserName}\Documents\Exes"))
                {
                    File.Move(item, $@"C:\Users\{Environment.UserName}\Documents\Exes\" + Path.GetFileName(item));
                }

                if (imageFiles.Contains(fi.Extension))
                {
                    File.Move(item, $@"C:\Users\{Environment.UserName}\Pictures\" + Path.GetFileName(item));
                }

                if (videoFiles.Contains(fi.Extension))
                {
                    File.Move(item, $@"C:\Users\{Environment.UserName}\Videos\" + Path.GetFileName(item));
                }

            }*/

            //Reading directory name and not extension of files inside maybe need to redo the linq
            string[] mainDir = Directory.GetDirectories($@"C:\Users\{Environment.UserName}\Downloads");
                List<string> extensionList = new List<string>();


            foreach (var childDir in mainDir)
            {

                string[] childFiles = Directory.GetFiles(childDir);

                foreach (var grandChildFiles in childFiles)
                {
                    FileInfo fileInfo = new FileInfo(grandChildFiles);
                    if (videoFiles.Contains(fileInfo.Extension))
                    {
                        
                        extensionList.Add(childDir);

                    }
                   
                }

                if (extensionList.Contains(childDir))
                {
                    Directory.Move(childDir, $@"C:\Users\{Environment.UserName}\Videos\" + Path.GetFileName(childDir));

                }

            }

        }
    }
}
