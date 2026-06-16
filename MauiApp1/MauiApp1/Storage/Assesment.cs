using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Storage
{
    public class Assesment
    {
        [PrimaryKey, AutoIncrement]
        public int assesmentId { get; set; }
        public int courseId { get; set; }
        public string Name { get; set; }
        public string assesmentType { get; set; }
        public DateTime startDate { get; set; }
        public DateTime dueDate{ get; set; }
        public string courseInfo { get; set; }


        public int notificationActivation { get; set; }
    }
}
