using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KENTUCKY_WATCHBILL1.Storage
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int userId { get; set; }
        public string userPassword { get; set; }
        public string userName { get; set; }
        public string sailorName { get; set; }
        public string role { get; set; }

    }
}
