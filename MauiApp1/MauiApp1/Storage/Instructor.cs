using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Storage
{
    public class Instructor
    {
        [PrimaryKey,AutoIncrement]
        public int instructorId { get; set; }
        public string Name { get; set; }
        
        public string phone { get; set; }
        public string email { get; set; }
    }
}
