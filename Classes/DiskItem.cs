using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commander_Jr.Classes
{
    public abstract class DiskItem
    {
        public string path { get; set; }
        public DateTime dateOfCreation { get; set; }

        public DiskItem(string path)
        {
            this.path = path;
        }

        public abstract Boolean isFile();
        public abstract string getName();

    }
}
