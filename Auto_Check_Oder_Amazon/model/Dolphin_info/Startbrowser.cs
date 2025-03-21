using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Check_Oder_Amazon.model.Dolphin_info
{
    public class Startbrowser
    {
        public bool success { get; set; }
        public Automation automation { get; set; }
    }

    public class Automation
    {
        public int port { get; set; }
        public string wsEndpoint { get; set; }
    }

}
