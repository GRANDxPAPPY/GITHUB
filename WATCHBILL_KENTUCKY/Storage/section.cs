using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WATCHBILL_KENTUCKY.Storage
{
    public class Section
    {
        [PrimaryKey,AutoIncrement]
        public int sectionId { get; set; }
        public int userId { get; set; }
        public string sectionName { get; set; }

    }
}
