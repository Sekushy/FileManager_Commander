using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Commander_Jr.Classes
{
    class Utility
    {
        TabControl leftTab;
        TabControl rightTab;
        SidePanel leftPanel;
        SidePanel rigthPanel;
        Boolean isDelete;
        Boolean isCopySuccesful;

        public Utility(TabControl leftTab, TabControl rightTab)
        {
            this.leftTab = leftTab;
            this.rightTab = rightTab;
        }

    }
}
