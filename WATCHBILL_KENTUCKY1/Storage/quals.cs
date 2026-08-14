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
        public int sectionId { get; set; }
        public bool BDW { get; set; }
        public bool POOD { get; set; }
        public bool TRW { get; set; }
        public int M18 { get; set; }
        public int M500 { get; set; }

    }
}
