using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander_Jr.Classes
{
    public class Directory : DiskItem
    {
        public Directory(string path) : base(path)
        {
            dateOfCreation = System.IO.Directory.GetCreationTime(path);
        }

        public override String getName()
        {
            // You take the whole path to the given directory and then split the string at the final backslash
            // the +1 one at the end takes the next substring after the final backslash.
            return path.Substring(path.LastIndexOf(@"\") + 1);
        }

        public override Boolean isFile()
        {
            return false;
        }

        public List<DiskItem> getSubItems()
        {
            List<DiskItem> diskItems = new List<DiskItem>();
            String[] directories = System.IO.Directory.GetDirectories(path);
            String[] files = System.IO.Directory.GetFiles(path);

            foreach (var item in directories)
            {
                diskItems.Add(new Directory(item));
            }

            return diskItems;
        }
    }
}
