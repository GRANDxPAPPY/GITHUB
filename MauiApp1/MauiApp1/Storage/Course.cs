
using Microsoft.VisualBasic;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Storage
{
    public class Course
    {
        [PrimaryKey,AutoIncrement]
        public int courseId { get; set; }
        public int termId { get; set; }
        public string courseName { get; set; }
        public int active { get; set; }
        public DateTime courseStartDate { get; set; }
        public DateTime courseEndDate { get; set; }

        

        public int instructorId { get; set; }
        
        
    }
}
