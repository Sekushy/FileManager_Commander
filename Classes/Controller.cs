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
        public String nameOfItem { get; set; }
        public String extensionOfItem { get; set; }
        public String pathOfItem { get; set; }
        public Boolean isItemFile { get; set; }
        public DateTime itemDateOfCreation { get; set; }

        public Controller (DiskItem diskItem)
        {
            this.diskItem = diskItem;
            nameOfItem = diskItem.getName();
            isItemFile = diskItem.isFile();
            pathOfItem = diskItem.path;
            itemDateOfCreation = diskItem.dateOfCreation;
            if (diskItem is Directory)
            {
                Directory temporary = (Directory)diskItem;
                extensionOfItem = "<DIR>";
            } else
            {

            }
        }
    }
}
