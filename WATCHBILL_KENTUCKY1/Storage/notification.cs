using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KENTUCKY_WATCHBILL1.Storage
{
    public class Notes
    {
        [PrimaryKey, AutoIncrement]
        public int noteId { get; set; }

    }
}
