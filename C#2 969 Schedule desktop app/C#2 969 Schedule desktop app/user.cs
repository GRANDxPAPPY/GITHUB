using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_969_Schedule_desktop_app
{


        public class user
        {
            public int userId { get; set; }
            public string userName { get; set; }
            public string password { get; set; }
            public bool active { get; set; }
            public DateTime createDate { get; set; }
            public string createdBy { get; set; }
            public DateTime lastUpdate { get; set; }
            public string lastUpdateBy { get; set; }
        }
    }