using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KENTUCKY_WATCHBILL1.Storage
{
    public class Quals
    {
        [PrimaryKey, AutoIncrement]
        public int qualId { get; set; }
        public int userId { get; set; }
        public int BDW { get; set; }
        public int POOD { get; set; }
        public int TRW { get; set; }
        public int M18 { get; set; }
        public int M500 { get; set; }

    }
}
