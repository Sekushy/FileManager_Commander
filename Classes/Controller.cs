using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander_Jr.Classes
{
    class Controller
    {
        DiskItem diskItem;
        public String Name { get; set; }
        public String Type { get; set; }
        public String pathOfItem { get; set; }
        public Boolean isItemFile { get; set; }
        public DateTime DateOfCreation { get; set; }

        public Controller (DiskItem diskItem)
        {
            this.diskItem = diskItem;
            Name = diskItem.getName();
            isItemFile = diskItem.isFile();
            pathOfItem = diskItem.path;
            DateOfCreation = diskItem.dateOfCreation;
            if (diskItem is Directory)
            {
                Directory temporary = (Directory)diskItem;
                Type = "<DIR>";
            } else
            {
                File temporary = (File)diskItem;
                Type = temporary.extension;
            }
        }
    }
}
