using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander_Jr.Classes
{
    public class File : DiskItem
    {
        public String extension { get; }
        public long size { get; }

        public String getFileExtension(String path)
        {
            return path.Substring(path.LastIndexOf(@".") + 1);
        }
        public File(String path) : base(path)
        {
            FileInfo fileInfo = new FileInfo(path);
            extension = getFileExtension(path);
            dateOfCreation = System.IO.File.GetCreationTime(path);
            size = fileInfo.Length;
        }

        public override String getName()
        {
            return path.Substring(path.LastIndexOf(@"\") + 1);
        }

        public override Boolean isFile()
        {
            return true;
        }
    }
}
