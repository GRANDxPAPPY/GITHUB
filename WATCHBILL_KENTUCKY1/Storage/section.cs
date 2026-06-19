using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KENTUCKY_WATCHBILL1.Storage
{
    public class Section
    {
        [PrimaryKey,AutoIncrement]
        public int sectionId { get; set; }
        public int userId { get; set; }
        public string sectionName { get; set; }

    }
}
