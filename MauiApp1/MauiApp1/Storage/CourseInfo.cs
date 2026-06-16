using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Storage
{
    public class CourseInfo
    {
        [AutoIncrement,PrimaryKey]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseBody { get; set; }
    }
}
