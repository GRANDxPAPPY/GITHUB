using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KENTUCKY_WATCHBILL1.Storage
{
    public class SectionLeader
    {
        [PrimaryKey,AutoIncrement]
        public int sectionLeaderId { get; set; }
        public int userId { get; set; }

        public int sectionId { get; set; }
        


    }
}
