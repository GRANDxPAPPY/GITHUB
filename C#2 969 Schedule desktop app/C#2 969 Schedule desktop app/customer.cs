using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2_969_Schedule_desktop_app
{
    public class customer
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
        public int addressID { get; set; }
        public bool active { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        
        public string customerAddress { get; set; }
        public string phone { get; set; }
    }
}