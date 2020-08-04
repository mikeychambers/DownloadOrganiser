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
            string[] files = Directory.GetFiles("C:\\Users\\507\\Downloads");
            foreach (var item in files)
            {
                FileInfo fi = new FileInfo(item);

                if (fi.Extension == ".exe" )
                {

                    File.Move(item ,@"C:\Users\507\Documents\exes\" + Path.GetFileName(item));

                }

                if (fi.Extension == ".jpg" || fi.Extension == ".png" || fi.Extension == ".jpeg")
                {
                    File.Move(item, @"C:\Users\507\Pictures\" + Path.GetFileName(item));
                }

            }

        }
    }
}
