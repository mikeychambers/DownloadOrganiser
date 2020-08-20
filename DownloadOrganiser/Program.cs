using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DownloadOrganiser
{
    class Program
    {
        static void Main(string[] args)
        {
            bool createExeFile = false;
            string[] imageFiles = { ".jpg", ".jpeg", ".jpe", ".jif", ".jfif", ".jfi" ,".png", ".gif", ".webp", ".tiff", ".tif",
                ".psd", ".raw", ".arw", ".cr2", ".nrw", ".k25", ".bmp", ".dib", ".heif", ".heic", ".ind", ".indd", ".indt", ".jp2", ".j2k", ".jpf", ".jpx", ".jpm", ".mj2",
                ".svg", ".svgz", ".ai", ".eps"};
            string[] videoFiles = {".webm", ".mpg", ".mp2", ".mpeg", ".mpe", ".mpv", ".ogg", ".mp4", ".m4p", ".m4v", ".avi", ".wmv", ".mov", ".qt", ".flv", ".swf", ".avchd" };

            string[] files = Directory.GetFiles($"C:\\Users\\{Environment.UserName}\\Downloads");

            foreach (var item in files)
            {
                FileInfo fi = new FileInfo(item);

                if (fi.Extension == ".exe")
                {

                    File.Move(item ,$@"C:\Users\{Environment.UserName}\Documents\Exes\" + Path.GetFileName(item));

                }

                if (imageFiles.Contains(fi.Extension))
                {
                    File.Move(item, $@"C:\Users\{Environment.UserName}\Pictures\" + Path.GetFileName(item));
                }

                if (videoFiles.Contains(fi.Extension))
                {
                    File.Move(item, $@"C:\Users\{Environment.UserName}\Videos\" + Path.GetFileName(item));
                }

            }

        }
    }
}
