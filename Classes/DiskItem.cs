using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander_Jr.Classes
{
    public abstract class DiskItem
    {
        public String path { get; set; }
        public DateTime dateOfCreation { get; set; }

        public DiskItem(String Path)
        {
            path = this.path;
        }

        public abstract Boolean isFile();
        public abstract String getName();

    }
}
