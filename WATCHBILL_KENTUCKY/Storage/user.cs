using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace WATCHBILL_KENTUCKY.Storage
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int userId { get; set; }
        public string userPassword { get; set; }
        public string userName { get; set; }
        public string sailorName { get; set; }
        
    }
}
